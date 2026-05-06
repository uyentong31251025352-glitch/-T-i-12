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
        public Node Link;
        public Node(Post data) 
        { 
            this.Data = data; 
            this.Link = null; 
        }
    }

    public class PostList
    {
        public Node Head; 

        public void AddFirst(Post newPost)
        {
            Node newNode = new Node(newPost);
            newNode.Link = this.Head;
            this.Head = newNode;
        }


        public bool DeletePost(string id)
        {
            if (this.Head == null) return false;
            if (this.Head.Data.ID == id)
            {
                this.Head = this.Head.Link;
                return true;
            }
            Node current = this.Head;
            while (current.Link != null && current.Link.Data.ID != id)
            {
                current = current.Link;
            }
            if (current.Link != null)
            {
                current.Link = current.Link.Link; 
                return true;
            }
            return false;
        }
        public bool UpdatePost(string id, string newContent)
        {
            Node current = this.Head;
            while (current != null)
            {
                if (current.Data.ID == id)
                {
                    current.Data.Content = newContent;
                    return true;
                }
                current = current.Link; 
            }
            return false;
        }
        public List<Post> SearchByContent(string keyword)
        {
            List<Post> results = new List<Post>();
            Node current = this.Head;

            // Chuyển từ khóa về chữ thường trước 1 lần để tối ưu
            string Key = keyword.ToLower();

            while (current != null)
            {
                // Kiểm tra xem nội dung (đã viết thường) có chứa từ khóa không
                if (current.Data.Content.ToLower().Contains(Key))
                {
                    results.Add(current.Data);
                }
                current = current.Link;
            }

            return results;
        }

    }
}
