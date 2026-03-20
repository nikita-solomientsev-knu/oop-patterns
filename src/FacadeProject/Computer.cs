namespace FacadeProject;


public class Computer {
    private readonly PowerSupply _power = new PowerSupply();
    private readonly HighSpeedBus _highSpeedBus = new HighSpeedBus();
    private readonly System _system = new System();
    private bool _isOn = false;

    public void TurnOn() {
        _power.Enable();
        _highSpeedBus.SetConnectivity();
        _system.SetSingleUserMode();
        _system.SetMultiUserMode();
        _system.SetFullMultiUserMode();
        _system.SetGui();
        _isOn = _power.IsActive() && _highSpeedBus.IsReady() && _system.IsReady();
    }

    public bool IsOn() {
        return _isOn;
    }
}
