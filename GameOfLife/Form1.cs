using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace GameOfLife
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class point
        {
            public int x;
            public int y;

            public point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        bool[,] grid;
        int[,] numOfNeighbors;
        bool[] S = new bool[9];
        bool[] B = new bool[9];
        bool[,] checkGrid;
        List<point> check = new List<point>();
        List<point> checkNext = new List<point>();

        float zoom;
        int width, height;

        bool gridChecked;

        static Bitmap bmp;
        static Graphics g;

        static bool contains(List<point> list, int x, int y)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].x == x && list[i].y == y)
                {
                    return true;
                }
            }
            return false;
        }

        static bool contains(List<point> list, point p)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].x == p.x && list[i].y == p.y)
                {
                    return true;
                }
            }
            return false;
        }

        public void placeRabbits()
        {
            placeBlackSquare(width / 2 - 3, height / 2 - 1, true);
            placeBlackSquare(width / 2 + 1, height / 2 - 1, true);
            placeBlackSquare(width / 2 + 2, height / 2 - 1, true);
            placeBlackSquare(width / 2 + 3, height / 2 - 1, true);
            placeBlackSquare(width / 2 - 3, height / 2, true);
            placeBlackSquare(width / 2 - 2, height / 2, true);
            placeBlackSquare(width / 2 - 1, height / 2, true);
            placeBlackSquare(width / 2 + 2, height / 2, true);
            placeBlackSquare(width / 2 - 2, height / 2 + 1, true);
        }

        public void drawGrid()
        {
            if (zoom >= 3 && gridChecked)
            {
                for (float a = 0; a < height; a += zoom)
                {
                    g.DrawLine(Pens.Gray, 0, a, width - 1, a);
                }
                for (float a = 0; a < width; a += zoom)
                {
                    g.DrawLine(Pens.Gray, a, 0, a, width - 1);
                }
            }
        }

        public void drawBlackSquare(int x, int y)
        {
            g.FillRectangle(Brushes.Black, (float)Math.Floor((x - (width - width / zoom) / 2) * zoom), (float)Math.Floor((y - (height - height / zoom) / 2) * zoom), zoom, zoom);
        }

        public void placeBlackSquare(int x, int y, bool draw)
        {
            grid[x, y] = true;
            addSquareToCheck(x, y);
            if(draw)
            {
                drawBlackSquare(x, y);
            }
        }

        public void addSquareToCheck(int x, int y)
        {
            for (int a = -1; a <= 1; a++)
            {
                for (int b = -1; b <= 1; b++)
                {
                    int newX = x + a;
                    int newY = y + b;
                    if(newX >= 0 && newX < width && newY >= 0 && newY < height && !checkGrid[newX, newY])
                    {
                        checkNext.Add(new point(newX, newY));
                        checkGrid[newX, newY] = true;
                    }
                }
            }
        }

        public void placeWhiteSquare(int x, int y)
        {
            grid[x, y] = false;
            g.FillRectangle(Brushes.White, (x - (width - width / zoom) / 2) * zoom, (y - (height - height / zoom) / 2) * zoom, zoom, zoom);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridChecked = gridCheckBox.Checked;
            width = pictureBox1.Width;
            height = pictureBox1.Height;
            grid = new bool[width, height];
            numOfNeighbors = new int[width, height];
            checkGrid = new bool[width, height];
            clear(checkGrid);
            bmp = new Bitmap(width, height);
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            zoom = (float)zoomNumericUpDown.Value;
            ruleComboBox.SelectedItem = "Game of Life";
            resetRules();
            clear(grid);
            placeRabbits();
            drawGrid();
            pictureBox1.Image = bmp;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            drawGrid();
            generationLabel.Text = Convert.ToString(Convert.ToInt32(generationLabel.Text) + 1);
            check = new List<point>(checkNext);
            checkNext.Clear();
            clear(checkGrid);

            foreach (point p in check)
            {
                numOfNeighbors[p.x, p.y] = 0;
                for (int c = -1; c <= 1; c++)
                {
                    for (int d = -1; d <= 1; d++)
                    {
                        if (!(c == 0 && d == 0))
                        {
                            int x = p.x + c;
                            int y = p.y + d;
                            if (x >= 0 && y >= 0 && x < width && y < height)
                            {
                                if (grid[p.x + c, p.y + d])
                                {
                                    numOfNeighbors[p.x, p.y] += 1;
                                }
                            }
                        }
                    }
                }
            }

            foreach (point p in check)
            {
                if (grid[p.x, p.y])
                {
                    bool placed = false;
                    for (int i = 0; i < 9 && !placed; i++)
                    {
                        if (S[i])
                        {
                            if (numOfNeighbors[p.x, p.y] == i)
                            {
                                placeBlackSquare(p.x, p.y, true);
                                placed = true;
                            }
                            else
                            {
                                grid[p.x, p.y] = false;
                            }
                        }
                    }
                }
                else
                {
                    bool placed = false;
                    for (int i = 0; i < 9 && !placed; i++)
                    {
                        if (B[i] && numOfNeighbors[p.x, p.y] == i)
                        {
                            placeBlackSquare(p.x, p.y, true);
                            placed = true;
                        }
                    }
                }
            }
            pictureBox1.Image = bmp;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            resetRules();
            if (ruleComboBox.SelectedIndex == 0)
            {
                checkBoxS0.CheckState = CheckState.Unchecked;
                checkBoxS1.CheckState = CheckState.Unchecked;
                checkBoxS2.CheckState = CheckState.Checked;
                checkBoxS3.CheckState = CheckState.Checked;
                checkBoxS4.CheckState = CheckState.Unchecked;
                checkBoxS5.CheckState = CheckState.Unchecked;
                checkBoxS6.CheckState = CheckState.Unchecked;
                checkBoxS7.CheckState = CheckState.Unchecked;
                checkBoxS8.CheckState = CheckState.Unchecked;
                checkBoxB0.CheckState = CheckState.Unchecked;
                checkBoxB1.CheckState = CheckState.Unchecked;
                checkBoxB2.CheckState = CheckState.Unchecked;
                checkBoxB3.CheckState = CheckState.Checked;
                checkBoxB4.CheckState = CheckState.Unchecked;
                checkBoxB5.CheckState = CheckState.Unchecked;
                checkBoxB6.CheckState = CheckState.Unchecked;
                checkBoxB7.CheckState = CheckState.Unchecked;
                checkBoxB8.CheckState = CheckState.Unchecked;
            }
            else if ((string)ruleComboBox.SelectedItem == "Własna zasada")
            { }
            else if ((string)ruleComboBox.SelectedItem == "High Life")
            {
                checkBoxS0.CheckState = CheckState.Unchecked;
                checkBoxS1.CheckState = CheckState.Unchecked;
                checkBoxS2.CheckState = CheckState.Checked;
                checkBoxS3.CheckState = CheckState.Checked;
                checkBoxS4.CheckState = CheckState.Unchecked;
                checkBoxS5.CheckState = CheckState.Unchecked;
                checkBoxS6.CheckState = CheckState.Unchecked;
                checkBoxS7.CheckState = CheckState.Unchecked;
                checkBoxS8.CheckState = CheckState.Unchecked;
                checkBoxB0.CheckState = CheckState.Unchecked;
                checkBoxB1.CheckState = CheckState.Unchecked;
                checkBoxB2.CheckState = CheckState.Unchecked;
                checkBoxB3.CheckState = CheckState.Checked;
                checkBoxB4.CheckState = CheckState.Unchecked;
                checkBoxB5.CheckState = CheckState.Unchecked;
                checkBoxB6.CheckState = CheckState.Checked;
                checkBoxB7.CheckState = CheckState.Unchecked;
                checkBoxB8.CheckState = CheckState.Unchecked;
            }
            else if ((string)ruleComboBox.SelectedItem == "Semena")
            {
                checkBoxS0.CheckState = CheckState.Unchecked;
                checkBoxS1.CheckState = CheckState.Unchecked;
                checkBoxS2.CheckState = CheckState.Unchecked;
                checkBoxS3.CheckState = CheckState.Unchecked;
                checkBoxS4.CheckState = CheckState.Unchecked;
                checkBoxS5.CheckState = CheckState.Unchecked;
                checkBoxS6.CheckState = CheckState.Unchecked;
                checkBoxS7.CheckState = CheckState.Unchecked;
                checkBoxS8.CheckState = CheckState.Unchecked;
                checkBoxB0.CheckState = CheckState.Unchecked;
                checkBoxB1.CheckState = CheckState.Unchecked;
                checkBoxB2.CheckState = CheckState.Checked;
                checkBoxB3.CheckState = CheckState.Unchecked;
                checkBoxB4.CheckState = CheckState.Unchecked;
                checkBoxB5.CheckState = CheckState.Unchecked;
                checkBoxB6.CheckState = CheckState.Unchecked;
                checkBoxB7.CheckState = CheckState.Unchecked;
                checkBoxB8.CheckState = CheckState.Unchecked;
            }
            else if ((string)ruleComboBox.SelectedItem == "Ubrousky")
            {
                checkBoxS0.CheckState = CheckState.Unchecked;
                checkBoxS1.CheckState = CheckState.Unchecked;
                checkBoxS2.CheckState = CheckState.Unchecked;
                checkBoxS3.CheckState = CheckState.Unchecked;
                checkBoxS4.CheckState = CheckState.Unchecked;
                checkBoxS5.CheckState = CheckState.Unchecked;
                checkBoxS6.CheckState = CheckState.Unchecked;
                checkBoxS7.CheckState = CheckState.Unchecked;
                checkBoxS8.CheckState = CheckState.Unchecked;
                checkBoxB0.CheckState = CheckState.Unchecked;
                checkBoxB1.CheckState = CheckState.Unchecked;
                checkBoxB2.CheckState = CheckState.Checked;
                checkBoxB3.CheckState = CheckState.Checked;
                checkBoxB4.CheckState = CheckState.Checked;
                checkBoxB5.CheckState = CheckState.Unchecked;
                checkBoxB6.CheckState = CheckState.Unchecked;
                checkBoxB7.CheckState = CheckState.Unchecked;
                checkBoxB8.CheckState = CheckState.Unchecked;
            }
            else if ((string)ruleComboBox.SelectedItem == "Vločky")
            {
                checkBoxS0.CheckState = CheckState.Checked;
                checkBoxS1.CheckState = CheckState.Checked;
                checkBoxS2.CheckState = CheckState.Checked;
                checkBoxS3.CheckState = CheckState.Checked;
                checkBoxS4.CheckState = CheckState.Checked;
                checkBoxS5.CheckState = CheckState.Checked;
                checkBoxS6.CheckState = CheckState.Checked;
                checkBoxS7.CheckState = CheckState.Checked;
                checkBoxS8.CheckState = CheckState.Checked;
                checkBoxB0.CheckState = CheckState.Unchecked;
                checkBoxB1.CheckState = CheckState.Unchecked;
                checkBoxB2.CheckState = CheckState.Unchecked;
                checkBoxB3.CheckState = CheckState.Checked;
                checkBoxB4.CheckState = CheckState.Unchecked;
                checkBoxB5.CheckState = CheckState.Unchecked;
                checkBoxB6.CheckState = CheckState.Unchecked;
                checkBoxB7.CheckState = CheckState.Unchecked;
                checkBoxB8.CheckState = CheckState.Unchecked;
            }
            else if ((string)ruleComboBox.SelectedItem == "Suky")
            {
                checkBoxS0.CheckState = CheckState.Unchecked;
                checkBoxS1.CheckState = CheckState.Checked;
                checkBoxS2.CheckState = CheckState.Unchecked;
                checkBoxS3.CheckState = CheckState.Unchecked;
                checkBoxS4.CheckState = CheckState.Unchecked;
                checkBoxS5.CheckState = CheckState.Unchecked;
                checkBoxS6.CheckState = CheckState.Unchecked;
                checkBoxS7.CheckState = CheckState.Unchecked;
                checkBoxS8.CheckState = CheckState.Unchecked;
                checkBoxB0.CheckState = CheckState.Unchecked;
                checkBoxB1.CheckState = CheckState.Checked;
                checkBoxB2.CheckState = CheckState.Unchecked;
                checkBoxB3.CheckState = CheckState.Unchecked;
                checkBoxB4.CheckState = CheckState.Unchecked;
                checkBoxB5.CheckState = CheckState.Unchecked;
                checkBoxB6.CheckState = CheckState.Unchecked;
                checkBoxB7.CheckState = CheckState.Unchecked;
                checkBoxB8.CheckState = CheckState.Unchecked;
            }
            else if ((string)ruleComboBox.SelectedItem == "Bludiště")
            {
                checkBoxS0.CheckState = CheckState.Unchecked;
                checkBoxS1.CheckState = CheckState.Checked;
                checkBoxS2.CheckState = CheckState.Checked;
                checkBoxS3.CheckState = CheckState.Checked;
                checkBoxS4.CheckState = CheckState.Checked;
                checkBoxS5.CheckState = CheckState.Checked;
                checkBoxS6.CheckState = CheckState.Unchecked;
                checkBoxS7.CheckState = CheckState.Unchecked;
                checkBoxS8.CheckState = CheckState.Unchecked;
                checkBoxB0.CheckState = CheckState.Unchecked;
                checkBoxB1.CheckState = CheckState.Unchecked;
                checkBoxB2.CheckState = CheckState.Unchecked;
                checkBoxB3.CheckState = CheckState.Checked;
                checkBoxB4.CheckState = CheckState.Unchecked;
                checkBoxB5.CheckState = CheckState.Unchecked;
                checkBoxB6.CheckState = CheckState.Unchecked;
                checkBoxB7.CheckState = CheckState.Unchecked;
                checkBoxB8.CheckState = CheckState.Unchecked;
            }
            else if ((string)ruleComboBox.SelectedItem == "2x2")
            {
                checkBoxS0.CheckState = CheckState.Unchecked;
                checkBoxS1.CheckState = CheckState.Checked;
                checkBoxS2.CheckState = CheckState.Checked;
                checkBoxS3.CheckState = CheckState.Unchecked;
                checkBoxS4.CheckState = CheckState.Unchecked;
                checkBoxS5.CheckState = CheckState.Checked;
                checkBoxS6.CheckState = CheckState.Unchecked;
                checkBoxS7.CheckState = CheckState.Unchecked;
                checkBoxS8.CheckState = CheckState.Unchecked;
                checkBoxB0.CheckState = CheckState.Unchecked;
                checkBoxB1.CheckState = CheckState.Unchecked;
                checkBoxB2.CheckState = CheckState.Unchecked;
                checkBoxB3.CheckState = CheckState.Checked;
                checkBoxB4.CheckState = CheckState.Unchecked;
                checkBoxB5.CheckState = CheckState.Unchecked;
                checkBoxB6.CheckState = CheckState.Checked;
                checkBoxB7.CheckState = CheckState.Unchecked;
                checkBoxB8.CheckState = CheckState.Unchecked;
            }
            else if ((string)ruleComboBox.SelectedItem == "Nahrazovač")
            {
                checkBoxS0.CheckState = CheckState.Unchecked;
                checkBoxS1.CheckState = CheckState.Checked;
                checkBoxS2.CheckState = CheckState.Unchecked;
                checkBoxS3.CheckState = CheckState.Checked;
                checkBoxS4.CheckState = CheckState.Unchecked;
                checkBoxS5.CheckState = CheckState.Checked;
                checkBoxS6.CheckState = CheckState.Unchecked;
                checkBoxS7.CheckState = CheckState.Checked;
                checkBoxS8.CheckState = CheckState.Unchecked;
                checkBoxB0.CheckState = CheckState.Unchecked;
                checkBoxB1.CheckState = CheckState.Checked;
                checkBoxB2.CheckState = CheckState.Unchecked;
                checkBoxB3.CheckState = CheckState.Checked;
                checkBoxB4.CheckState = CheckState.Unchecked;
                checkBoxB5.CheckState = CheckState.Checked;
                checkBoxB6.CheckState = CheckState.Unchecked;
                checkBoxB7.CheckState = CheckState.Checked;
                checkBoxB8.CheckState = CheckState.Unchecked;
            }
            else if ((string)ruleComboBox.SelectedItem == "Améba")
            {
                checkBoxS0.CheckState = CheckState.Unchecked;
                checkBoxS1.CheckState = CheckState.Checked;
                checkBoxS2.CheckState = CheckState.Unchecked;
                checkBoxS3.CheckState = CheckState.Checked;
                checkBoxS4.CheckState = CheckState.Unchecked;
                checkBoxS5.CheckState = CheckState.Checked;
                checkBoxS6.CheckState = CheckState.Unchecked;
                checkBoxS7.CheckState = CheckState.Unchecked;
                checkBoxS8.CheckState = CheckState.Checked;
                checkBoxB0.CheckState = CheckState.Unchecked;
                checkBoxB1.CheckState = CheckState.Unchecked;
                checkBoxB2.CheckState = CheckState.Unchecked;
                checkBoxB3.CheckState = CheckState.Checked;
                checkBoxB4.CheckState = CheckState.Unchecked;
                checkBoxB5.CheckState = CheckState.Checked;
                checkBoxB6.CheckState = CheckState.Unchecked;
                checkBoxB7.CheckState = CheckState.Checked;
                checkBoxB8.CheckState = CheckState.Unchecked;
            }
            else if ((string)ruleComboBox.SelectedItem == "Města za zdmi")
            {
                checkBoxS0.CheckState = CheckState.Unchecked;
                checkBoxS1.CheckState = CheckState.Unchecked;
                checkBoxS2.CheckState = CheckState.Checked;
                checkBoxS3.CheckState = CheckState.Checked;
                checkBoxS4.CheckState = CheckState.Checked;
                checkBoxS5.CheckState = CheckState.Checked;
                checkBoxS6.CheckState = CheckState.Unchecked;
                checkBoxS7.CheckState = CheckState.Unchecked;
                checkBoxS8.CheckState = CheckState.Unchecked;
                checkBoxB0.CheckState = CheckState.Unchecked;
                checkBoxB1.CheckState = CheckState.Unchecked;
                checkBoxB2.CheckState = CheckState.Unchecked;
                checkBoxB3.CheckState = CheckState.Unchecked;
                checkBoxB4.CheckState = CheckState.Checked;
                checkBoxB5.CheckState = CheckState.Checked;
                checkBoxB6.CheckState = CheckState.Checked;
                checkBoxB7.CheckState = CheckState.Checked;
                checkBoxB8.CheckState = CheckState.Checked;
            }
            else if ((string)ruleComboBox.SelectedItem == "Skvrny")
            {
                checkBoxS0.CheckState = CheckState.Unchecked;
                checkBoxS1.CheckState = CheckState.Unchecked;
                checkBoxS2.CheckState = CheckState.Checked;
                checkBoxS3.CheckState = CheckState.Checked;
                checkBoxS4.CheckState = CheckState.Unchecked;
                checkBoxS5.CheckState = CheckState.Checked;
                checkBoxS6.CheckState = CheckState.Checked;
                checkBoxS7.CheckState = CheckState.Checked;
                checkBoxS8.CheckState = CheckState.Checked;
                checkBoxB0.CheckState = CheckState.Unchecked;
                checkBoxB1.CheckState = CheckState.Unchecked;
                checkBoxB2.CheckState = CheckState.Unchecked;
                checkBoxB3.CheckState = CheckState.Checked;
                checkBoxB4.CheckState = CheckState.Unchecked;
                checkBoxB5.CheckState = CheckState.Unchecked;
                checkBoxB6.CheckState = CheckState.Checked;
                checkBoxB7.CheckState = CheckState.Checked;
                checkBoxB8.CheckState = CheckState.Checked;
            }
            else if ((string)ruleComboBox.SelectedItem == "Srážlivý")
            {
                checkBoxS0.CheckState = CheckState.Unchecked;
                checkBoxS1.CheckState = CheckState.Unchecked;
                checkBoxS2.CheckState = CheckState.Checked;
                checkBoxS3.CheckState = CheckState.Checked;
                checkBoxS4.CheckState = CheckState.Unchecked;
                checkBoxS5.CheckState = CheckState.Checked;
                checkBoxS6.CheckState = CheckState.Checked;
                checkBoxS7.CheckState = CheckState.Checked;
                checkBoxS8.CheckState = CheckState.Checked;
                checkBoxB0.CheckState = CheckState.Unchecked;
                checkBoxB1.CheckState = CheckState.Unchecked;
                checkBoxB2.CheckState = CheckState.Unchecked;
                checkBoxB3.CheckState = CheckState.Checked;
                checkBoxB4.CheckState = CheckState.Unchecked;
                checkBoxB5.CheckState = CheckState.Unchecked;
                checkBoxB6.CheckState = CheckState.Unchecked;
                checkBoxB7.CheckState = CheckState.Checked;
                checkBoxB8.CheckState = CheckState.Checked;
            }
            else if ((string)ruleComboBox.SelectedItem == "Pseudo life")
            {
                checkBoxS0.CheckState = CheckState.Unchecked;
                checkBoxS1.CheckState = CheckState.Unchecked;
                checkBoxS2.CheckState = CheckState.Checked;
                checkBoxS3.CheckState = CheckState.Checked;
                checkBoxS4.CheckState = CheckState.Unchecked;
                checkBoxS5.CheckState = CheckState.Unchecked;
                checkBoxS6.CheckState = CheckState.Unchecked;
                checkBoxS7.CheckState = CheckState.Unchecked;
                checkBoxS8.CheckState = CheckState.Checked;
                checkBoxB0.CheckState = CheckState.Unchecked;
                checkBoxB1.CheckState = CheckState.Unchecked;
                checkBoxB2.CheckState = CheckState.Unchecked;
                checkBoxB3.CheckState = CheckState.Checked;
                checkBoxB4.CheckState = CheckState.Unchecked;
                checkBoxB5.CheckState = CheckState.Checked;
                checkBoxB6.CheckState = CheckState.Unchecked;
                checkBoxB7.CheckState = CheckState.Checked;
                checkBoxB8.CheckState = CheckState.Unchecked;
            }
            else if ((string)ruleComboBox.SelectedItem == "Pohyb")
            {
                checkBoxS0.CheckState = CheckState.Unchecked;
                checkBoxS1.CheckState = CheckState.Unchecked;
                checkBoxS2.CheckState = CheckState.Checked;
                checkBoxS3.CheckState = CheckState.Unchecked;
                checkBoxS4.CheckState = CheckState.Checked;
                checkBoxS5.CheckState = CheckState.Checked;
                checkBoxS6.CheckState = CheckState.Unchecked;
                checkBoxS7.CheckState = CheckState.Unchecked;
                checkBoxS8.CheckState = CheckState.Unchecked;
                checkBoxB0.CheckState = CheckState.Unchecked;
                checkBoxB1.CheckState = CheckState.Unchecked;
                checkBoxB2.CheckState = CheckState.Unchecked;
                checkBoxB3.CheckState = CheckState.Checked;
                checkBoxB4.CheckState = CheckState.Unchecked;
                checkBoxB5.CheckState = CheckState.Unchecked;
                checkBoxB6.CheckState = CheckState.Checked;
                checkBoxB7.CheckState = CheckState.Unchecked;
                checkBoxB8.CheckState = CheckState.Checked;
            }
            else if ((string)ruleComboBox.SelectedItem == "34 Life")
            {
                checkBoxS0.CheckState = CheckState.Unchecked;
                checkBoxS1.CheckState = CheckState.Unchecked;
                checkBoxS2.CheckState = CheckState.Unchecked;
                checkBoxS3.CheckState = CheckState.Checked;
                checkBoxS4.CheckState = CheckState.Checked;
                checkBoxS5.CheckState = CheckState.Unchecked;
                checkBoxS6.CheckState = CheckState.Unchecked;
                checkBoxS7.CheckState = CheckState.Unchecked;
                checkBoxS8.CheckState = CheckState.Unchecked;
                checkBoxB0.CheckState = CheckState.Unchecked;
                checkBoxB1.CheckState = CheckState.Unchecked;
                checkBoxB2.CheckState = CheckState.Unchecked;
                checkBoxB3.CheckState = CheckState.Checked;
                checkBoxB4.CheckState = CheckState.Checked;
                checkBoxB5.CheckState = CheckState.Unchecked;
                checkBoxB6.CheckState = CheckState.Unchecked;
                checkBoxB7.CheckState = CheckState.Unchecked;
                checkBoxB8.CheckState = CheckState.Unchecked;
            }
            else if ((string)ruleComboBox.SelectedItem == "Day & Night")
            {
                checkBoxS0.CheckState = CheckState.Unchecked;
                checkBoxS1.CheckState = CheckState.Unchecked;
                checkBoxS2.CheckState = CheckState.Unchecked;
                checkBoxS3.CheckState = CheckState.Checked;
                checkBoxS4.CheckState = CheckState.Checked;
                checkBoxS5.CheckState = CheckState.Unchecked;
                checkBoxS6.CheckState = CheckState.Checked;
                checkBoxS7.CheckState = CheckState.Checked;
                checkBoxS8.CheckState = CheckState.Checked;
                checkBoxB0.CheckState = CheckState.Unchecked;
                checkBoxB1.CheckState = CheckState.Unchecked;
                checkBoxB2.CheckState = CheckState.Unchecked;
                checkBoxB3.CheckState = CheckState.Checked;
                checkBoxB4.CheckState = CheckState.Unchecked;
                checkBoxB5.CheckState = CheckState.Unchecked;
                checkBoxB6.CheckState = CheckState.Checked;
                checkBoxB7.CheckState = CheckState.Checked;
                checkBoxB8.CheckState = CheckState.Checked;
            }
            else if ((string)ruleComboBox.SelectedItem == "Přizpůsobení")
            {
                checkBoxS0.CheckState = CheckState.Unchecked;
                checkBoxS1.CheckState = CheckState.Unchecked;
                checkBoxS2.CheckState = CheckState.Unchecked;
                checkBoxS3.CheckState = CheckState.Unchecked;
                checkBoxS4.CheckState = CheckState.Checked;
                checkBoxS5.CheckState = CheckState.Checked;
                checkBoxS6.CheckState = CheckState.Checked;
                checkBoxS7.CheckState = CheckState.Checked;
                checkBoxS8.CheckState = CheckState.Unchecked;
                checkBoxB0.CheckState = CheckState.Unchecked;
                checkBoxB1.CheckState = CheckState.Unchecked;
                checkBoxB2.CheckState = CheckState.Unchecked;
                checkBoxB3.CheckState = CheckState.Checked;
                checkBoxB4.CheckState = CheckState.Checked;
                checkBoxB5.CheckState = CheckState.Checked;
                checkBoxB6.CheckState = CheckState.Unchecked;
                checkBoxB7.CheckState = CheckState.Unchecked;
                checkBoxB8.CheckState = CheckState.Unchecked;
            }
            else if ((string)ruleComboBox.SelectedItem == "Korál")
            {
                checkBoxS0.CheckState = CheckState.Unchecked;
                checkBoxS1.CheckState = CheckState.Unchecked;
                checkBoxS2.CheckState = CheckState.Unchecked;
                checkBoxS3.CheckState = CheckState.Unchecked;
                checkBoxS4.CheckState = CheckState.Checked;
                checkBoxS5.CheckState = CheckState.Checked;
                checkBoxS6.CheckState = CheckState.Checked;
                checkBoxS7.CheckState = CheckState.Checked;
                checkBoxS8.CheckState = CheckState.Checked;
                checkBoxB0.CheckState = CheckState.Unchecked;
                checkBoxB1.CheckState = CheckState.Unchecked;
                checkBoxB2.CheckState = CheckState.Unchecked;
                checkBoxB3.CheckState = CheckState.Checked;
                checkBoxB4.CheckState = CheckState.Unchecked;
                checkBoxB5.CheckState = CheckState.Unchecked;
                checkBoxB6.CheckState = CheckState.Unchecked;
                checkBoxB7.CheckState = CheckState.Unchecked;
                checkBoxB8.CheckState = CheckState.Unchecked;
            }
            else if ((string)ruleComboBox.SelectedItem == "Long life")
            {
                checkBoxS0.CheckState = CheckState.Unchecked;
                checkBoxS1.CheckState = CheckState.Unchecked;
                checkBoxS2.CheckState = CheckState.Unchecked;
                checkBoxS3.CheckState = CheckState.Unchecked;
                checkBoxS4.CheckState = CheckState.Unchecked;
                checkBoxS5.CheckState = CheckState.Checked;
                checkBoxS6.CheckState = CheckState.Unchecked;
                checkBoxS7.CheckState = CheckState.Unchecked;
                checkBoxS8.CheckState = CheckState.Unchecked;
                checkBoxB0.CheckState = CheckState.Unchecked;
                checkBoxB1.CheckState = CheckState.Unchecked;
                checkBoxB2.CheckState = CheckState.Unchecked;
                checkBoxB3.CheckState = CheckState.Checked;
                checkBoxB4.CheckState = CheckState.Checked;
                checkBoxB5.CheckState = CheckState.Checked;
                checkBoxB6.CheckState = CheckState.Unchecked;
                checkBoxB7.CheckState = CheckState.Unchecked;
                checkBoxB8.CheckState = CheckState.Unchecked;
            }
            else if ((string)ruleComboBox.SelectedItem == "Kosoaméba")
            {
                checkBoxS0.CheckState = CheckState.Unchecked;
                checkBoxS1.CheckState = CheckState.Unchecked;
                checkBoxS2.CheckState = CheckState.Unchecked;
                checkBoxS3.CheckState = CheckState.Unchecked;
                checkBoxS4.CheckState = CheckState.Unchecked;
                checkBoxS5.CheckState = CheckState.Checked;
                checkBoxS6.CheckState = CheckState.Checked;
                checkBoxS7.CheckState = CheckState.Checked;
                checkBoxS8.CheckState = CheckState.Checked;
                checkBoxB0.CheckState = CheckState.Unchecked;
                checkBoxB1.CheckState = CheckState.Unchecked;
                checkBoxB2.CheckState = CheckState.Unchecked;
                checkBoxB3.CheckState = CheckState.Checked;
                checkBoxB4.CheckState = CheckState.Unchecked;
                checkBoxB5.CheckState = CheckState.Checked;
                checkBoxB6.CheckState = CheckState.Checked;
                checkBoxB7.CheckState = CheckState.Checked;
                checkBoxB8.CheckState = CheckState.Checked;
            }
            S[0] = checkBoxS0.Checked;
            S[1] = checkBoxS1.Checked;
            S[2] = checkBoxS2.Checked;
            S[3] = checkBoxS3.Checked;
            S[4] = checkBoxS4.Checked;
            S[5] = checkBoxS5.Checked;
            S[6] = checkBoxS6.Checked;
            S[7] = checkBoxS7.Checked;
            S[8] = checkBoxS8.Checked;
            B[0] = checkBoxB0.Checked;
            B[1] = checkBoxB1.Checked;
            B[2] = checkBoxB2.Checked;
            B[3] = checkBoxB3.Checked;
            B[4] = checkBoxB4.Checked;
            B[5] = checkBoxB5.Checked;
            B[6] = checkBoxB6.Checked;
            B[7] = checkBoxB7.Checked;
            B[8] = checkBoxB8.Checked;
            timer1.Start();
        }
        
        private void Reset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            generationLabel.Text = "0";
            
            g.Clear(Color.White);
            clear(grid);
            clear(checkGrid);
            
            check.Clear();
            checkNext.Clear();
            placeRabbits();
            drawGrid();
            pictureBox1.Image = bmp;
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void mrzizka_CheckedChanged(object sender, EventArgs e)
        {
            gridChecked = gridCheckBox.Checked;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!timer1.Enabled)
            {
                int x = (int)(e.Location.X / zoom + (width - width / zoom) / 2);
                int y = (int)(e.Location.Y / zoom + (height - height / zoom) / 2);
                if (grid[x, y])
                {
                    placeWhiteSquare(x, y);
                }
                else
                {
                    placeBlackSquare(x, y, true);
                }
                drawGrid();
                pictureBox1.Image = bmp;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            zoom = (float)zoomNumericUpDown.Value;
            if (!timer1.Enabled)
            {
                g.Clear(Color.White);
                drawGrid();
                placeRabbits();
                pictureBox1.Image = bmp;
            }
        }

        public void resetRules()
        {
            for(int i = 0; i < 9; i++)
            {
                S[i] = B[i] = false;
            }
        }

        public void clear(bool[,] grid)
        {
            for(int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    grid[x, y] = false;
                }
            }
        }

        public void clear(int[,] grid)
        {
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    grid[x, y] = 0;
                }
            }
        }
    }
}
