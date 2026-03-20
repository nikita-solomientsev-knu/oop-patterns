

namespace FacadeProject {
    public class PowerSupply {
        private bool _isActive = false;

        public void Enable() {
            _isActive = true;
        }

        public bool IsActive() {
            return _isActive;
        }
    }

    public class HighSpeedBus {
        private bool _isReady = false;

        public void SetConnectivity() {
            _isReady = true;
        }

        public bool IsReady() {
            return _isReady;
        }
    }

    public class System {
        private uint _runlevel = 0;

        public void SetSingleUserMode() {
            _runlevel = 1;
        }

        public void SetMultiUserMode() {
            _runlevel = 2;
        }

        public void SetFullMultiUserMode() {
            _runlevel = 3;
        }

        public void SetGui() {
            _runlevel = 5;
        }

        public bool IsReady() {
            return _runlevel == 5;
        }
    }
}
