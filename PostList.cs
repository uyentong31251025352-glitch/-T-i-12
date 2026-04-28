using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đề_Tài_12
{
    public class Node
    {
        public Post Data;
        public Node Next;
        public Node(Post data) { this.Data = data; this.Next = null; }
    }

    public class PostList
    {
        public Node Head; // Mắt xích đầu tiên

        // Hàm Thêm vào đầu
        public void AddFirst(Post newPost)
        {
            Node newNode = new Node(newPost);
            newNode.Next = this.Head;
            this.Head = newNode;
        }

        // Hàm Xóa theo ID (Dùng cho nút xóa riêng từng bài)
        public bool DeletePost(string id)
        {
            if (this.Head == null) return false;
            if (this.Head.Data.ID == id)
            {
                this.Head = this.Head.Next;
                return true;
            }
            Node current = this.Head;
            while (current.Next != null && current.Next.Data.ID != id)
            {
                current = current.Next;
            }
            if (current.Next != null)
            {
                current.Next = current.Next.Next; // Bẻ Link bắc cầu
                return true;
            }
            return false;
        }
    }
}
