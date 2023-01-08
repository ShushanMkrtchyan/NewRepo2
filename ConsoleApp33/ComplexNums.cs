using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    
        class ComplexNums
        {
            int real, imag;

            public ComplexNums(int r, int i)
            {
                real = r;
                imag = i;

            }

            public void Show()
            {
                Console.WriteLine(real + "+" + imag + "*i");
            }

            public static ComplexNums operator +(ComplexNums num1, ComplexNums num2)
            {
                ComplexNums num3 = new ComplexNums(num1.real + num2.real, num1.imag + num2.imag);
                return num3;
            }

            public static ComplexNums operator -(ComplexNums num1, ComplexNums num2)
            {
                ComplexNums num3 = new ComplexNums(num1.real - num2.real, num1.imag - num2.imag);
                return num3;
            }

            public static bool operator >(ComplexNums num1, ComplexNums num2)
            {
                return num1.real * num2.real > num1.imag * num2.imag;

            }

            public static bool operator <(ComplexNums num1, ComplexNums num2)
            {
                return num1.real * num2.real < num1.imag * num2.imag;
            }

            public static bool operator ==(ComplexNums num1, ComplexNums num2)
            {
                return num1.real == num2.real && num1.imag == num2.imag;
            }

            public static bool operator !=(ComplexNums num1, ComplexNums num2)
            {
                return num1.real != num2.real && num1.imag != num2.imag;
            }


            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                {
                    return false;
                }
                ComplexNums c = obj as ComplexNums;
                return c.real == this.real && c.imag == this.imag;
            }

            public override int GetHashCode()
            {
                return real ^ imag;
            }


            public static bool operator true(ComplexNums c)
            {
                return c.real != 0 || c.imag != 0;
            }

            public static bool operator false(ComplexNums c)
            {
                return c.real != 0 || c.imag != 0;
            }

            public static ComplexNums operator |(ComplexNums c1, ComplexNums c2)
            {
                if ((c1.real != 0 && c1.imag != 0) | (c2.real != 0 && c2.imag != 0))
                    return new ComplexNums(2, 2);
                else
                    return new ComplexNums(0, 0);


            }

            public static ComplexNums operator &(ComplexNums c1, ComplexNums c2)
            {
                if ((c1.real != 0 && c1.imag != 0) | (c2.real != 0 && c2.imag != 0))
                    return new ComplexNums(2, 2);
                else
                    return new ComplexNums(0, 0);

            }

            public static explicit operator string(ComplexNums c)

            {
                return c.real.ToString();

            }

        }
    }

