using System;
using System.Collections ;
namespace aStar
{
	
	public class Node:IComparable 
	{

		public int totalCost
		{
			get 
			{
				return g+h;
			}
			set
			{
				totalCost = value;
			}
		}
		public int g;
		public int h;


		
		public int x;
		public int y;

		
		private Node _goalNode;
		public Node parentNode;
		private int gCost;


		public Node(Node parentNode, Node goalNode, int gCost,int x, int y)
		{
			
			this.parentNode = parentNode;
			this._goalNode = goalNode;
			this.gCost = gCost;
			this.x=x;
			this.y=y;
			InitNode();
		}
	
		private void InitNode()
		{
			this.g = (parentNode!=null)? this.parentNode.g + gCost:gCost;
			this.h = (_goalNode!=null)? (int) Euclidean_H():0;
		}

		private double Euclidean_H()
		{
			double xd = this.x - this._goalNode .x ;
			double yd = this.y - this._goalNode .y ;
			return 10*Math.Sqrt((xd*xd) + (yd*yd));
		}
		
		public int CompareTo(object obj)
		{
			
			Node n = (Node) obj;
			int cFactor = this.totalCost - n.totalCost ;
			return cFactor;
		}

		public bool isMatch(Node n)
		{
			if (n!=null)
				return (x==n.x && y==n.y);
			else
				return false;
		}

		public ArrayList GetSuccessors()
		{
			ArrayList successors = new ArrayList ();

            if (MapForm.allowDiagonal)
            {
                for (int xd = -1; xd <= 1; xd++)
                {
                    for (int yd = -1; yd <= 1; yd++)
                    {
                        if (Map.getMap(x + xd, y + yd) != -1)
                        {
                            //Node n = new Node(this, this._goalNode, Map.getMap(x + xd, y + yd), x + xd, y + yd);
                            //Node n = new Node(this, this._goalNode, 10, x + xd, y + yd);
                            //Node n = new Node(this, this._goalNode, (int)(10 * Math.Sqrt(xd * xd + yd * yd)), x + xd, y + yd);
                            Node n = new Node(this, this._goalNode, (xd==0||yd==0)?10:14, x + xd, y + yd);
                            if (!n.isMatch(this.parentNode) && !n.isMatch(this))
                                successors.Add(n);

                        }
                    }
                }
            }
            else
            {
                int[,] combinations = { { 1, 0 }, { -1, 0 }, { 0, 1 }, { 0, -1 } };
                for (int i = 0; i < combinations.GetLength(0); i++)
                {
                    int xd = combinations[i, 0], yd = combinations[i, 1];
                    if (Map.getMap(x + xd, y + yd) != -1)
                    {
                        Node n = new Node(this, this._goalNode, 10, x + xd, y + yd);
                        if (!n.isMatch(this.parentNode) && !n.isMatch(this))
                            successors.Add(n);

                    }
                }
            }
			return successors;
		}
	}
}
