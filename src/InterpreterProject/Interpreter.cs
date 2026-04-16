namespace InterpreterProject {

    public interface IExpression {
        public int Interpretate();
    }

    public class Interpretator: IExpression {
        private string _str;

        public Interpretator(string str) {
            _str = str;
        }

        public int Interpretate() {
            if (_str.Contains('+'))
            {
                return new AdditionInterpretator(_str).Interpretate();
            }
            if (_str.Contains('-'))
            {
                return new SubtractionInterpretator(_str).Interpretate();
            }
            if (_str.Contains('*'))
            {
                return new MultiplicationInterpretator(_str).Interpretate();
            }
            if (_str.Contains('/'))
            {
                return new DivisionInterpretator(_str).Interpretate();
            }
            if (_str.Any(char.IsDigit))
            {
                return new NumberInterpretator(_str).Interpretate();
            }
            throw new ArgumentException($"The given input string {_str} does not contain any valid expressions");
        }
        
    }

    public class MultiplicationInterpretator: IExpression {

        private string _str;

        public MultiplicationInterpretator(string str) {
            _str = str;
        }

        public int Interpretate() {
            string[] substrings = _str.Split(new[] {'*'}, 2, StringSplitOptions.RemoveEmptyEntries);
            return new Interpretator(substrings[0]).Interpretate() * new Interpretator(substrings[1]).Interpretate();
        }
    }

    public class DivisionInterpretator: IExpression {

        private string _str;

        public DivisionInterpretator(string str) {
            _str = str;
        }

        public int Interpretate() {
            string[] substrings = _str.Split(new[] {'/'}, 2, StringSplitOptions.RemoveEmptyEntries);
            return new Interpretator(substrings[0]).Interpretate() / new Interpretator(substrings[1]).Interpretate();
        }
    }


    public class AdditionInterpretator: IExpression {

        private string _str;

        public AdditionInterpretator(string str) {
            _str = str;
        }

        public int Interpretate() {
            string[] substrings = _str.Split(new[] {'+'}, 2, StringSplitOptions.RemoveEmptyEntries);
            return new Interpretator(substrings[0]).Interpretate() + new Interpretator(substrings[1]).Interpretate();
        }
    }


    public class SubtractionInterpretator: IExpression {

        private string _str;

        public SubtractionInterpretator(string str) {
            _str = str;
        }

        public int Interpretate() {
            string[] substrings = _str.Split(new[] {'-'}, 2, StringSplitOptions.RemoveEmptyEntries);
            return new Interpretator(substrings[0]).Interpretate() - new Interpretator(substrings[1]).Interpretate();
        }
    }


    public class NumberInterpretator: IExpression {

        private string _str;

        public NumberInterpretator(string str) {
            _str = str;
        }

        public int Interpretate() {
            return int.Parse(_str);
        }
    }

}
