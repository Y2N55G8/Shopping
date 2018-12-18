using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopping.Areas.Manage.Models.wl
{
    public class Clfiy
    {
        public int id { get; set; }
        public string  text { get; set; }
        public List<Clfiy> children { get; set; }
        public string icon { get; set; }
        public int cid { get; set; }

        public Clfiy()
        {
            id = -1;
            text = "选择分类";
            children = null;
            icon = "none";
            cid = -1;
        }
        
        public Clfiy(Classfiy classfiy, List<Classfiy> classfiys)
        {
            id = classfiy.C_no;
            text = classfiy.C_name;
            icon = "none";
            cid = classfiy.C_cno;
            children = (from l in classfiys where l.C_cno == classfiy.C_no select new Clfiy(l, classfiys)).ToList();
           
        }
    }
}