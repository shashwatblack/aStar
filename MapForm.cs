using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aStar
{
    public partial class MapForm : Form
    {
        public static bool allowDiagonal = false;
        private int[] gridSize;
        public MapForm()
        {
            InitializeComponent();
            Reset();
            initMap();
        }

        private async void initMap()
        {
            //System.Threading.Thread.Sleep(50);
            await Task.Delay(300);
            //Draw start and end nodes
            System.Drawing.Graphics g = pictureBoxMapArea.CreateGraphics();
            g.FillRectangle(new SolidBrush(Color.Green), Map.node_start.x * gridSize[0], Map.node_start.y * gridSize[1], gridSize[0], gridSize[1]);
            g.FillRectangle(new SolidBrush(Color.Red), Map.node_goal.x * gridSize[0], Map.node_goal.y * gridSize[1], gridSize[0], gridSize[1]);
        }

        private void buttonFindPath_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello World!", "Hi", MessageBoxButtons.OK);
            //System.Drawing.Graphics graphics = this.pictureBox1.CreateGraphics();
            //System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(100, 100, 200, 200);
            //graphics.DrawEllipse(System.Drawing.Pens.Black, rectangle);
            //graphics.DrawRectangle(System.Drawing.Pens.Red, rectangle);
            this.solve();
        }

        private void pictureBoxMapArea_MouseClick(object sender, MouseEventArgs e)
        {
            Point boxPos = new Point(gridSize[0] * (int)(e.X / gridSize[0]), gridSize[1] * (int)(e.Y / gridSize[1]));
            System.Drawing.Graphics g = pictureBoxMapArea.CreateGraphics();
            //System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(100, 100, 30, 30);
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(boxPos.X, boxPos.Y, gridSize[0], gridSize[1]);
            Color color;
            if (this.radioStart.Checked){
                color = Color.Green;
                //change start node in Map class
                Map.node_start = new Node(null, Map.node_goal, 1, (int)(e.X / gridSize[0]), (int)(e.Y / gridSize[1]));
            }
            else if (this.radioGoal.Checked){
                color = Color.Red;
                //change goal node in Map class
                Map.node_goal = new Node(null, null, 1, (int)(e.X / gridSize[0]), (int)(e.Y / gridSize[1]));
            }
            else if (this.radioWall.Checked){
                color = Color.Black;
                //draw a wall on map
                Map.Mapdata[(int)(e.Y / gridSize[1]) , (int)(e.X / gridSize[0])] = -1;
            }
            else{
                color = Color.Khaki;
                //clear the position of any entity
                Map.Mapdata[(int)(e.Y / gridSize[1]) , (int)(e.X / gridSize[0])] = 1;
            }
            g.FillRectangle(new SolidBrush(color), rectangle);
        }
        
        private void drawSolution(ArrayList solutionPathList)
        {
            int yMax = Map.Mapdata.GetUpperBound(0);
            int xMax = Map.Mapdata.GetUpperBound(1);
            System.Drawing.Graphics g = pictureBoxMapArea.CreateGraphics();
            Color color;
            for (int j = 0; j <= yMax; j++)
            {
                for (int i = 0; i <= xMax; i++)
                {
                    bool solutionNode = false;
                    Node tmp = new Node(null, null, 0, i, j);
                    if (solutionPathList != null)
                    {
                        foreach (Node n in solutionPathList)
                        {
                            //if (tmp.isMatch(Map.node_start)) {
                            //    solutionNode = false;
                            //    break;
                            //} else if (tmp.isMatch(Map.node_goal)) {
                            //    solutionNode = false;
                            //    break;
                            //} else 
                            if (n.isMatch(tmp)) {
                                solutionNode = true;
                                break;
                            }
                        }
                    }
                    else
                    {
                        solutionNode = false;
                    }
                    if (tmp.isMatch(Map.node_start))
                    {
                        color = Color.Green;
                    }
                    else if (tmp.isMatch(Map.node_goal))
                    {
                        color = Color.Red;
                    }
                    else if (solutionNode)
                    {
                        //Console.Write("o "); //solution path
                        color = Color.Blue;
                    }
                    else if (Map.getMap(i, j) == -1)
                    {
                        //Console.Write("# "); //wall
                        color = Color.Black;
                    }
                    else 
                    {
                        //Console.Write(". "); //road
                        color = Color.Khaki;
                    }
                    g.FillRectangle(new SolidBrush(color), i * gridSize[0], j * gridSize[1], gridSize[0], gridSize[1]);
                }
                //Console.WriteLine("");
            }
            if (solutionPathList != null) this.labelCost.Text = ("Total Weight: " + solutionPathList.ToArray().GetUpperBound(0));
        }

        private void solve()
        {

            ArrayList SolutionPathList = new ArrayList();

            //Create a node containing the goal state node_goal
            Node node_goal = Map.node_goal;

            //Create a node containing the start state node_start
            Node node_start = Map.node_start;


            //Create OPEN and CLOSED list
            SortedCostNodeList OPEN = new SortedCostNodeList();
            SortedCostNodeList CLOSED = new SortedCostNodeList();


            //Put node_start on the OPEN list
            OPEN.push(node_start);

            //while the OPEN list is not empty
            while (OPEN.Count > 0)
            {
                //Get the node off the open list 
                //with the lowest f and call it node_current
                Node node_current = OPEN.pop();

                //if node_current is the same state as node_goal we have found the solution;
                //break from the while loop;
                if (node_current.isMatch(node_goal))
                {
                    node_goal.parentNode = node_current.parentNode;
                    break;
                }

                //Generate each state node_successor that can come after node_current
                ArrayList successors = node_current.GetSuccessors();

                //for each node_successor or node_current
                foreach (Node node_successor in successors)
                {
                    //Set the cost of node_successor to be the cost of node_current plus
                    //the cost to get to node_successor from node_current
                    //--> already set while we are getting successors

                    //find node_successor on the OPEN list
                    int oFound = OPEN.IndexOf(node_successor);

                    //if node_successor is on the OPEN list but the existing one is as good
                    //or better then discard this successor and continue
                    if (oFound >= 0)
                    {
                        Node existing_node = OPEN.NodeAt(oFound);
                        if (existing_node.CompareTo(node_current) <= 0)
                            continue;
                    }


                    //find node_successor on the CLOSED list
                    int cFound = CLOSED.IndexOf(node_successor);

                    //if node_successor is on the CLOSED list but the existing one is as good
                    //or better then discard this successor and continue;
                    if (cFound >= 0)
                    {
                        Node existing_node = CLOSED.NodeAt(cFound);
                        if (existing_node.CompareTo(node_current) <= 0)
                            continue;
                    }

                    //Remove occurences of node_successor from OPEN and CLOSED
                    if (oFound != -1)
                        OPEN.RemoveAt(oFound);
                    if (cFound != -1)
                        CLOSED.RemoveAt(cFound);

                    //Set the parent of node_successor to node_current;
                    //--> already set while we are getting successors

                    //Set h to be the estimated distance to node_goal (Using heuristic function)
                    //--> already set while we are getting successors

                    //Add node_successor to the OPEN list
                    OPEN.push(node_successor);

                }
                //Add node_current to the CLOSED list
                CLOSED.push(node_current);
            }


            //follow the parentNode from goal to start node
            //to find solution
            Node p = node_goal;
            while (p != null)
            {
                SolutionPathList.Insert(0, p);
                p = p.parentNode;
            }

            //display solution

            //Map.PrintSolution (SolutionPathList);
            //Console.ReadLine ();
            if (SolutionPathList != null)
                this.drawSolution(SolutionPathList);
        }

        private void Reset()
        {
            int yMax = Map.mapRows = (int)this.numericUpDownHeight.Value;
            int xMax = Map.mapCols = (int)this.numericUpDownWidth.Value;
            //calculate gridSize
            gridSize = new int[] {this.pictureBoxMapArea.Width/xMax, this.pictureBoxMapArea.Height/yMax};
            //define mapData and nodes
            Map.Mapdata = new int[yMax, xMax];
            Map.node_goal = new Node(null, null, 1, Map.Mapdata.GetUpperBound(1), Map.Mapdata.GetUpperBound(0));
            Map.node_start = new Node(null, Map.node_goal, 1, 0, 0);
            //clear the map
            for (int j = 0; j < xMax; j++)
            {
                for (int i = 0; i < yMax; i++)
                {
                    Map.Mapdata[i, j] = 1;
                }
            }
            //////reset gridSize controls
            //////this.numericUpDownWidth.Value = 20;
            //////this.numericUpDownHeight.Value = 20;
            //draw grid
            //draw null solution
            this.drawSolution(null);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void numericUpDownWidth_ValueChanged(object sender, EventArgs e)
        {
            Reset();
        }

        private void numericUpDownHeight_ValueChanged(object sender, EventArgs e)
        {
            Reset();
        }

        private void checkBoxDiagonal_CheckedChanged(object sender, EventArgs e)
        {
            //Reset();
            MapForm.allowDiagonal = this.checkBoxDiagonal.Checked;
        }

    }
}
