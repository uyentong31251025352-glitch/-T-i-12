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
        
    }
}
