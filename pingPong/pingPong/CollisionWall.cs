﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pingPong
{
    public partial class CollisionWall : UserControl
    {
        public static List<CollisionWall> ActiveWalls = new List<CollisionWall>();

        public CollisionWall()
        {
            InitializeComponent();
            ActiveWalls.Add(this);
        }
    }
}
