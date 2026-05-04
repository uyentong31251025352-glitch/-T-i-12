using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đề_Tài_12
{
    public partial class Form1 : Form
    {
        PostList postList = new PostList();

        public Form1()
        {
            InitializeComponent();
        }
        void Duyetdanhsach()

        {

            listBox1.Items.Clear();

            Node current = postList.Head;

            while (current != null)

            {

                listBox1.Items.Add(current.Data.ID + " - " + current.Data.Content);

                current = current.Next;

            }

        }
    }
}
