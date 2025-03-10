particle += $"\{color:["{Math.Round(color.R / 255.0d, 2).ToString("R", format)}"f, "{Math.Round(color.G / 255.0d, 2).ToString("R", format)}"f, "{Math.Round(color.B / 255.0d, 2).ToString("R", format)}"f],scale:"{double.Parse(ParticleSizeBox.Text).ToString("R", format)}"f}";


// particle minecraft:dust{colors:[1f, 1f, 1f],scale:1f} 1^ 1^ 1^ 0 0 0 0 1 @a force