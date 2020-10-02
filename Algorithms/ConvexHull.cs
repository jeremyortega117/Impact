using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace Algorithms
{
	class JarvisMarch
	{

		private DblLinkedList head;
		private DblLinkedList curr;
		private DblLinkedList prev;
		private DblLinkedList topEnd;
		private int size;

		// Gathers and runs the algorithm for the jarvise's march
		public JarvisMarch(int size)
		{
			this.size = size;
		}

		public DblLinkedList getHead()
		{
			return head;
		}
		public DblLinkedList getTopEnd()
		{
			return topEnd;
		}


		public void algoTop(Node[] node)
		{
			// check if we need to perform a convex hull algorithm.
			if (lessThanTwoCheck(node))
				return;

			// Go through all but the first and last index's
			for (int trav = 2; trav < size; trav++)
			{

				// find out if the current point is part of the convex hull or not.
				double hCheck = hullCheck(node, prev, curr, trav);
				DblLinkedList DLL = new DblLinkedList(node[trav]);

				/*
				 * Check if the convex Hull should be outside of the current node
				 */
				if (hCheck < curr.getNode().yVal)
				{

					/*
					 * Check each previous node on the convex hull until up until we are sure no current
					 * node will be fully contained in the new convex hull.
					 */
					while (prev != head)
					{
						/*
						 * Check each new convex hull compared to the previous node.
						 */
						double newHullCheck = hullCheck(node, prev.getPrev(), prev, trav);
						if (newHullCheck < prev.getNode().yVal)
						{
							prev = prev.getPrev();
							prev.setNext(DLL);
						}
						/*
						 * once we verify that we've found a previous convex hull node that won't change from the
						 * current new node, we quit.
						 */
						else
						{
							break;
						}
					}
					/*
					 * This handles the same situation as directly above but takes care not to go past the
					 * head.
					 */
					if (prev == head)
					{
						double newHullCheck = hullCheck(node, prev, prev.getNext(), trav);
						if (newHullCheck < prev.getNode().yVal)
						{
							prev.setNext(DLL);
						}
					}
					/*
					 * update the connection between the new next convex hull node and the last verified node
					 * on the convex hull.
					 */
					DLL.setPrev(prev);
					prev.setNext(DLL);
				}

				/*
				 * If the Current Node is Outside the convex hull Then it becomes a part of the new
				 * convex hull
				 */
				else
				{
					curr.setNext(DLL);
					DLL.setPrev(curr);
					prev = curr;
				}
				/*
				 * update the current node along the convex hull.
				 */
				curr = DLL;
				// printCurrList();
			}
			topEnd = curr;
			algoBottom(node);
		}

		/**
		 * Same as above however swapped the LESS with GREATER signs when checking if vertex are
		 * apart of the convex hull.
		 * @param NPC
		 */
		public void algoBottom(Node[] node)
		{

			DblLinkedList DLL_1 = new DblLinkedList(node[size - 1]);
			DLL_1.setPrev(topEnd);
			topEnd.setNext(DLL_1);

			prev = topEnd;
			curr = DLL_1;

			// Go through all but the first and last index's
			for (int trav = size - 2; trav > -1; trav--)
			{

				// find out if the current point is part of the convex hull or not.
				// double hullCheck = hullCheck(NPC, prev, curr, trav);
				double hullCheck = hullCheckBottom(node, prev, curr, trav);
				DblLinkedList DLL = new DblLinkedList(node[trav]);

				/*
				 * Check if the convex Hull should be outside of the current node
				 */
				if (hullCheck > curr.getNode().yVal)
				{

					/*
					 * Check each previous node on the convex hull until up until we are sure no current
					 * node will be fully contained in the new convex hull.
					 */
					while (prev != topEnd)
					{
						/*
						 * Check each new convex hull compared to the previous node.
						 */
						double newHullCheck = hullCheckBottom(node, prev.getPrev(), prev, trav);
						if (newHullCheck > prev.getNode().yVal)
						{
							prev = prev.getPrev();
							prev.setNext(DLL);
						}
						/*
						 * once we verify that we've found a previous convex hull node that won't change from the
						 * current new node, we quit.
						 */
						else
						{
							break;
						}
					}
					/*
					 * This handles the same situation as directly above but takes care not to go past the
					 * head.
					 */
					if (prev == topEnd)
					{
						double newHullCheck = hullCheckBottom(node, prev, prev.getNext(), trav);
						if (newHullCheck > prev.getNode().yVal)
						{
							prev.setNext(DLL);
						}
					}
					/*
					 * update the connection between the new next convex hull node and the last verified node
					 * on the convex hull.
					 */
					DLL.setPrev(prev);
					prev.setNext(DLL);
				}

				/*
				 * If the Current Node is Outside the convex hull Then it becomes a part of the new
				 * convex hull
				 */
				else
				{
					curr.setNext(DLL);
					DLL.setPrev(curr);
					prev = curr;
				}
				/*
				 * update the current node along the convex hull.
				 */
				curr = DLL;
				//printCurrList();
			}
			topEnd = curr;
			printCurrList();
		}


		/**
		 * Check if the number of NPC's in an area are 2 or less.
		 * @param NPC
		 * @return
		 */
		private Boolean lessThanTwoCheck(Node[] NPC)
		{
			// NPCs are zero
			if (NPC.Length == 0)
			{
				return true;
			}
			// create first linked list node.
			head = new DblLinkedList(NPC[0]);
			prev = head;
			if (NPC.Length == 1)
			{
				return true;
			}
			// Else prepare the second linked list.
			DblLinkedList DLL_Two = new DblLinkedList(NPC[1]);
			head.setNext(DLL_Two);
			DLL_Two.setPrev(head);
			curr = DLL_Two;
			if (NPC.Length == 2)
			{
				return true;
			}
			return false;
		}

		/**
		 * return the knowledge of whether or not a new point along the convex hull has been found.
		 * @param NPC
		 * @param pre
		 * @param trav
		 * @return
		 */
		private double hullCheck(Node[] node, DblLinkedList prev, DblLinkedList currCheck, int trav)
		{

			double nextX = node[trav].xVal;
			double nextY = node[trav].yVal;

			double prevX = prev.getNode().xVal;
			double prevY = prev.getNode().yVal;

			double thisX = currCheck.getNode().xVal;


			// (3, 2) and (6, 3) // y = mx + b
			double slope = (nextY - prevY) / (nextX - prevX);  // m
			double yInt = prevY - (slope * prevX);  // b

			// If this is lower than current point, the current point is no longer
			// a part of the hull.

			return slope * thisX + yInt;
		}
		/**
		 * Same as above but swapped the prev and next X and Y values so the slope intercept formula still works.
		 * @param NPC
		 * @param prev
		 * @param currCheck
		 * @param trav
		 * @return
		 */
		public double hullCheckBottom(Node[] node, DblLinkedList prev, DblLinkedList currCheck, int trav)
		{

			double prevX = node[trav].xVal;
			double prevY = node[trav].yVal;

			double nextX = prev.getNode().xVal;
			double nextY = prev.getNode().yVal;

			double thisX = currCheck.getNode().xVal;


			// (3, 2) and (6, 3) // y = mx + b
			double slope = (nextY - prevY) / (nextX - prevX);  // m
			double yInt = prevY - (slope * prevX);  // b

			// If this is lower than current point, the current point is no longer
			// a part of the hull.
			return slope * thisX + yInt;
		}

		public void printCurrList()
		{
			DblLinkedList Dbl = head;
			while (Dbl.getNext() != null)
			{
				Console.WriteLine("" + Dbl.getNode().id + ", ");
				Dbl = Dbl.getNext();
			}
			Console.WriteLine("" + Dbl.getNode().id);
		}
	}

}
