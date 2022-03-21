using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_rover
{
    public class Mars
    {
        string  m ;
        char o ;
        int dX, dY, dH, dW ;

        public Mars(int dH , int dW , int dX , int dY , char o , string m )
        {
            this.m = m ;
            this.dH = dH ;
            this.dW = dW ;
            this.dX = dX ;
            this.dY = dY ;
            this.o = o ;
        }
        public void calcul()
        {
            for (int i = 0; i < m.Length; i++)
			{
                if (m[i] == 'A')
                {
                    switch (o)
                    {
                        case 'N':
                            dY++;
                            break;
                        case 'S':
                            dY--;
                            break;
                        case 'E':
                            dX--;
                            break;
                        case 'W':
                            dX++;
                            break;
                    }
                }
                else
                {
                    o = VerifyO(o, m[i]);
                }
                
            }           
        }

        public char VerifyO(char o,char m)
        {
            if (m == 'R') {
                switch (o)
                {
                    case 'N':
                        return 'W';
                    case 'S':
                        return 'E';
                    case 'E':
                        return 'N';
                    case 'W':
                        return 'S';
                }
            }
            if (m == 'L')
            {
                switch (o)
                {
                    case 'N':
                        return 'E';
                    case 'S':
                        return 'W';
                    case 'E':
                        return 'S';
                    case 'W':
                        return 'N';
                }
            }
            return o;
        }

        public string Verify()
        {
            if (dX < 0 || dX >= dW || dY < 0 || dY >= dH)
            {
                return "false , "+o+" , ("+dX+","+dY+")";
            }
            else
            {
                return "true ," + o + " , (" + dX + "," + dY + ")";
            }
        }
        
}
}
