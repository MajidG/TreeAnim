using System.Collections.Generic;
using System.Drawing;

namespace GraphApp
{
    public class Node
    {
        public Point pos;
        public string text;
        public List<Node> subNodes = new List<Node>();
        int size = 40;
        static Pen pen = new Pen(Color.FromArgb(255,0,100, 0),2);
        static Font font = new Font("Consolas", 16, FontStyle.Bold);
        public Node(object text)
        {
            this.text = text.ToString();
        }
        public void Paint(Graphics g)
        {
            foreach (var node in subNodes)
            {
                g.DrawLine(pen, pos, node.pos);
            }
            Point dpos = new Point(pos.X - size / 2, pos.Y - size / 2);
            g.FillEllipse(Brushes.Green, new Rectangle(dpos, new Size(size, size)));
            //g.DrawEllipse(pen, new Rectangle(dpos, new Size(size, size)));
            g.DrawString(text, font, Brushes.White, pos.X - size / 4 +1 , pos.Y - size / 4-1);

            foreach (var node in subNodes)
                node.Paint(g);
        }

        public void AddSubNode(Node child)
        {
            if (subNodes.Contains(child))
                return;
            subNodes.Add(child);
        }

        public float Build(float startX, int lvl)
        {
            float size = 0;
            for (int i = 0; i < subNodes.Count; i++)
            {
                size += subNodes[i].Build(startX+size, lvl + 1);
            }
            if (subNodes.Count > 1)
            {
                pos.X = (subNodes[0].pos.X+subNodes[subNodes.Count-1].pos.X)/2;
            }
            else
            {
                pos.X = (int)startX;
            }
            pos.Y =lvl * 50 + 80;
            if (subNodes.Count == 0)
                size = 60;
            return size;
        }
    }
}
