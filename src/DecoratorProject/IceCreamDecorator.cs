namespace DecoratorProject {
    abstract public class IceCreamDecorator: IIceCream {
        private IIceCream _iceCreamInstance;

        public void SetIceCream(IIceCream iceCream) {
            _iceCreamInstance = iceCream;
        }

        virtual public string GetDescription() {
            return _iceCreamInstance.GetDescription();
        }
    }

    public class CreamyIceCreamDecorator: IceCreamDecorator {
        public override string GetDescription() {
            return "Creamy " + base.GetDescription();
        }
    }

    public class SweetIceCreamDecorator: IceCreamDecorator {
        public override string GetDescription() {
            return "Sweet " + base.GetDescription();
        }
    }
}
