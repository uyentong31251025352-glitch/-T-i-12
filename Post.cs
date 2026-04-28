using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đề_Tài_12
{
    class Post
    {
        public string ID { get; set; }
        public string Content { get; set; }
        public DateTime PostTime { get; set; }
        public int Likes { get; set; }

        public Post(string id, string content)
        {
            this.ID = id;
            this.Content = content;
            this.PostTime = DateTime.Now;
            this.Likes = 0;
        }
    }
}
