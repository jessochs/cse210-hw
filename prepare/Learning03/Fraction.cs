using System;
public class Fraction {
    //I guess you don't have to se the private to anything before?
            private int _top;
            private int _bottom;

            public Fraction() {
                _top = 1;
                _bottom = 1;

            }
            public Fraction(int top) {
                _top = top;
                _bottom = 1;
            }

            public Fraction(int top, int bottom) {
                _top = top;
                _bottom = bottom;
            }

//why doesn't the answer code show getters and setters like we're supposed to do?

            public int GetTop()
            {
                return _top;
            }

            public int SetTop(int top)
            {
                return _top;
            }

            public int GetBottom()
            {
                return _bottom;
            }

            public int SetBottom(int bottom)
            {
                return _bottom;
            }
            // public string GetFractionString(){
            //     string wholeFraction = $"{_top}/{_bottom}";
            // }
            public double GetDecimalValue(){

                return (double)_top / (double)_bottom;

            }

        }