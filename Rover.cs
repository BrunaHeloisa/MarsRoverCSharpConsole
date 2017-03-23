using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverCSharpConsole
{
    public class Rover
    {
        private string dir;
        private int coordx;
        private int coordy;

        public Rover() { }

        public Rover(int coordx, int coordy, string dir)
        {
            if (coordx<0)
            {
                coordx = coordx * (-1);
            }
            if (coordy<0)
            {
                coordy = coordy * (-1);
            }
            if ("W".Equals(dir)|| "E".Equals(dir)|| "N".Equals(dir)|| "S".Equals(dir))
            {
                this.dir = dir;
            }
            this.coordx = coordx;
            this.coordy = coordy;
        }
        public string getDir()
        {
            return this.dir;
        }

        public void setDir(string dir)
        {
            this.dir = dir;
        }

        public int getCoordx()
        {
            return this.coordx;
        }

        public void setCoordx(int coordx)
        {
            this.coordx = coordx;
        }

        public int getCoordy()
        {
            return this.coordy;
        }

        public void setCoordy(int coordy)
        {
            this.coordy = coordy;
        }

        public void mudaDir(string dir)
        {
            if ("L".Equals(dir) || "R".Equals(dir))
            {
                if ("R".Equals(dir))
                {
                    switch (this.dir)
                    {
                        case "N":
                            this.dir = "E";
                            break;
                        case "S":
                            this.dir = "W";
                            break;
                        case "W":
                            this.dir = "N";
                            break;
                        case "E":
                            this.dir = "S";
                            break;
                    }
                }
                else
                {
                    if ("L".Equals(dir))
                    {
                        switch (this.dir)
                        {
                            case "N":
                                this.dir = "W";
                                break;
                            case "S":
                                this.dir = "E";
                                break;
                            case "W":
                                this.dir = "S";
                                break;
                            case "E":
                                this.dir = "N";
                                break;
                        }
                    }
                }
            }
        }
        public void mover()
        {
            switch (this.getDir())
            {
                case "N":
                    this.coordy = this.coordy + 1;
                    break;
                case "S":
                    this.coordy = this.coordy - 1;
                    break;
                case "W":
                    this.coordx = this.coordx - 1;
                    break;
                case "E":
                    this.coordx = this.coordx + 1;
                    break;
            }
        }
    }
}
