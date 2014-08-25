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
        private Boolean longWallEnabled = false;
        private int[] longWallStartPoint = new int[2];
        
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
            try
            {
                Point boxPos = new Point(gridSize[0] * (int)(e.X / gridSize[0]), gridSize[1] * (int)(e.Y / gridSize[1]));
                System.Drawing.Graphics g = pictureBoxMapArea.CreateGraphics();
                //System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(100, 100, 30, 30);
                System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(boxPos.X, boxPos.Y, gridSize[0], gridSize[1]);
                Color color;
                if (this.radioStart.Checked)
                {
                    color = Color.Green;
                    //change start node in Map class
                    Map.node_start = new Node(null, Map.node_goal, 1, (int)(e.X / gridSize[0]), (int)(e.Y / gridSize[1]));
                    //clear wall if any
                    Map.Mapdata[(int)(e.Y / gridSize[1]), (int)(e.X / gridSize[0])] = 1;
                    //reset ui
                    this.drawSolution(null);
                }
                else if (this.radioGoal.Checked)
                {
                    color = Color.Red;
                    //change goal node in Map class
                    Map.node_goal = new Node(null, null, 1, (int)(e.X / gridSize[0]), (int)(e.Y / gridSize[1]));
                    //clear wall if any
                    Map.Mapdata[(int)(e.Y / gridSize[1]), (int)(e.X / gridSize[0])] = 1;
                    //reset ui
                    this.drawSolution(null);
                }
                else if (this.radioWall.Checked)
                {
                    color = Color.Black;
                    if (Form.ModifierKeys == Keys.Control)
                    {
                        if (this.longWallEnabled)
                        {
                            //draw line from start point to this point
                            foreach (Point p in BresenhamSolution.GetPointsOnLine(longWallStartPoint[0], longWallStartPoint[1],
                                (int)(e.X / gridSize[0]), (int)(e.Y / gridSize[0])))
                            {
                                Map.Mapdata[p.Y, p.X] = -1;
                                Point boxP = new Point(gridSize[0] * p.X, gridSize[1] * p.Y);
                                System.Drawing.Rectangle rect = new System.Drawing.Rectangle(boxP.X, boxP.Y, gridSize[0], gridSize[1]);
                                g.FillRectangle(new SolidBrush(color), rect);
                            }
                            //redefine start point = this point
                            longWallStartPoint[0] = (int)(e.X / gridSize[0]);
                            longWallStartPoint[1] = (int)(e.Y / gridSize[1]);
                        }
                        else
                        {
                            //draw wall on map
                            Map.Mapdata[(int)(e.Y / gridSize[1]), (int)(e.X / gridSize[0])] = -1;
                            //start point = this point
                            longWallStartPoint[0] = (int)(e.X / gridSize[0]);
                            longWallStartPoint[1] = (int)(e.Y / gridSize[1]);
                            this.longWallEnabled = true;
                        }
                    }
                    else
                    {
                        //draw a wall on map
                        Map.Mapdata[(int)(e.Y / gridSize[1]), (int)(e.X / gridSize[0])] = -1;
                    }
                }
                else
                {
                    color = Color.Khaki;
                    //clear the position of any entity
                    Map.Mapdata[(int)(e.Y / gridSize[1]), (int)(e.X / gridSize[0])] = 1;
                }
                g.FillRectangle(new SolidBrush(color), rectangle);
            } catch (IndexOutOfRangeException ex) {
                Console.WriteLine("IndexOutOfRangeException: " + ex.Message);
                // ignore and move on
            }
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
                            if (n.isMatch(tmp)) {
                                solutionNode = true;
                                break;
                            }
                        }
                    }

                    if (tmp.isMatch(Map.node_start)) {
                        color = Color.Green;
                    } else if (tmp.isMatch(Map.node_goal)) {
                        color = Color.Red;
                    } else if (solutionNode) {
                        color = Color.Blue;
                    } else if (Map.getMap(i, j) == -1) {
                        color = Color.Black;
                    } else {
                        color = Color.Khaki;
                    }

                    g.FillRectangle(new SolidBrush(color), i * gridSize[0], j * gridSize[1], gridSize[0], gridSize[1]);
                }
            }
            if (solutionPathList != null)
            {
                int cost = -1;
                foreach (Node n in solutionPathList)
                {
                    cost = n.totalCost; //>cost?n.totalCost:cost;
                    break;
                }
                this.labelCost.Text = ("Total Weight: " + cost); //solutionPathList.ToArray().GetUpperBound(0));
            } else Console.WriteLine("No solution case");

            //Clear the solution by resetting the goal node
            Map.node_goal.parentNode = null;
        }

        private void solve()
        {
            ArrayList SolutionPathList = new ArrayList();

            //Create a node containing the goal state node_goal
            Node node_goal = Map.node_goal;

            //Create a node containing the start state node_start
            Node node_start = Map.node_start;
            //node_start.totalCost = 10;


            //Create OPEN and CLOSED list
            SortedCostNodeList OPEN = new SortedCostNodeList();
            SortedCostNodeList CLOSED = new SortedCostNodeList();

            //Put node_start on the OPEN list
            OPEN.push(node_start);

            ArrayList successors;
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
                successors = node_current.GetSuccessors();

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
                        if (existing_node.CompareTo(node_successor) <= 0)
                            continue;
                    }


                    //find node_successor on the CLOSED list
                    int cFound = CLOSED.IndexOf(node_successor);

                    //if node_successor is on the CLOSED list but the existing one is as good
                    //or better then discard this successor and continue;
                    if (cFound >= 0)
                    {
                        Node existing_node = CLOSED.NodeAt(cFound);
                        if (existing_node.CompareTo(node_successor) <= 0)
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

            Map.PrintSolution (SolutionPathList);
            //Console.ReadLine ();
            //if (SolutionPathList != null)
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

        private void MapForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                this.longWallEnabled = false;
            }
        }

    }
}
