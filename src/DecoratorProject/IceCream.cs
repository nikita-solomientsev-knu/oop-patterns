using System.Collections.Generic;


namespace DecoratorProject {

    public interface IIceCream {
        public string GetDescription();
    }

    public class IceCream: IIceCream {
        private string _size;

        public IceCream(string size) {
            _size = size;
        }

        public string GetDescription() {
            return $"Ice cream size: {_size}";
        }

    }
}

