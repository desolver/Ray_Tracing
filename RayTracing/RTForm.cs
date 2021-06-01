﻿using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Numerics;
using System.Windows.Forms;

namespace RayTracing
{
    public partial class RTForm : Form
    {
        private Camera _camera = new Camera(
            600, 600, 
            (float) Math.PI / 3, 
            Vector3.Zero, 
            Vector3.UnitZ);

        public RTForm()
        {
            InitializeComponent();
            
            var image = RenderImage();

            Controls.Add(new PictureBox
            {
                Image = image,
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.CenterImage
            });
        }

        private Bitmap RenderImage()
        {
            var image = new Bitmap(_camera.Width - 1, _camera.Height - 1, PixelFormat.Format24bppRgb);

            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    var x = (float) ((2 * (i + 0.5) / Width - 1) * Math.Tan(_camera.FOV / 2) * Width / Height);
                    var y = (float) -((2 * (j + 0.5) / Height - 1) * Math.Tan(_camera.FOV / 2));

                    var direction = new Vector3(x, y, _camera.Direction.Z).Normalize();
                    var distToSphere = float.MaxValue;
                    var sphere = new Sphere(new Vector3(-3, -3, 10), 2);

                    var pixelColor = sphere.IsIntersectWithRay(_camera.Position, direction, ref distToSphere)
                        ? Color.Red
                        : Color.GreenYellow;

                    image.SetPixel(j, i, pixelColor);
                }
            }

            return image;
        }
    }
}
