            /*
            //后向量与其法线夹角总为90°，而转换向量的值必须在这个区间内
            //分别讨论1234象限内的角度增减
            //1
            if (LastPos.X > 0 & LastPos.Y > 0)
            {
                if (Rotain.X > 0)
                {
                    if (Rotain.X < LastPos.X && Rotain.X > 0 && Rotain.Y < LastPos.Y && Rotain.Y > 0)
                    {
                        Sign=1;
                    }
                    else
                    {
                        Sign=0;
                    }
                }
                else if (Rotain.X < 0)
                {
                    if (Rotain.X > - LastPos.X && Rotain.X < 0 && Rotain.Y < LastPos.Y && Rotain.Y > 0)
                    {
                        Sign=-1;
                    }
                    else
                    {
                        Sign=1;
                    }
                }
            }
            //2
            else if (LastPos.X < 0 & LastPos.Y > 0)
            {
                if (Rotain.Y > 0)
                {
                    if (Rotain.X <= LastPos.X && Rotain.X >= -LastPos.Y)
                    {
                        Sign = -1;
                    }
                    else
                    {
                        Sign = 1;
                    }
                }
                else if (Rotain.Y < 0)
                {
                    if (Rotain.X <= LastPos.Y && Rotain.Y <= -LastPos.X)
                    {
                        Sign=1;
                    }
                    else
                    {
                        Sign=-1;
                    }
                }
            }
            //3
            else if (LastPos.X < 0 & LastPos.Y < 0)
            {
                if (Rotain.X > LastPos.X && Rotain.X < - LastPos.Y && LastPos.Y < Rotain.Y && Rotain.Y < LastPos.X)
                {
                    Sign=-1;
                }
                else if (Rotain.X > LastPos.X && Rotain.X < LastPos.Y && LastPos.Y < Rotain.Y && Rotain.Y < - LastPos.X)
                {
                    Sign=1;
                }
                else
                {
                    Sign = -1;
                }
            }
            //4
            else if (LastPos.X > 0 & LastPos.Y < 0)
            {
                if (Rotain.X > -LastPos.Y && Rotain.X < LastPos.X && LastPos.X < Rotain.Y && Rotain.Y < LastPos.X)
                {
                    Sign = -1;
                }
                else if (Rotain.X > LastPos.Y && Rotain.X < LastPos.X && -LastPos.X < Rotain.Y && Rotain.Y < LastPos.Y)
                {
                    Sign = 1;
                }
                else
                {
                    Sign = 1;
                }
            }
            /*
            else if (Rotain.X == 0 || Rotain.Y == 0 )
            {
                Sign = 0;
            }
            
            //存在一些问题，需要更改
            */
