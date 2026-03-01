namespace PrototypeProject;


public class Computer: ICopy<Computer> {
    public Case Case { get; set; }
    public Cpu Cpu { get; set; }
    public Gpu Gpu { get; set; }
    public Ram Ram { get; set; }
    public Hdd Hdd { get; set; }
    public Motherboard Motherboard { get; set; }
    public Monitor Monitor { get; set; }

    public override string ToString() {
        return $$"""
        ________
        {{Case}}
        {{Cpu}}
        {{Gpu}}
        {{Ram}}
        {{Hdd}}
        {{Motherboard}}
        {{Monitor}}
        ---------
        
        """;
    }

    public Computer Copy() {
        return new Computer {
            Case = Case?.Copy(),
            Cpu = Cpu?.Copy(),
            Gpu = Gpu?.Copy(),
            Ram = Ram?.Copy(),
            Hdd = Hdd?.Copy(),
            Motherboard = Motherboard?.Copy(),
            Monitor = Monitor?.Copy()
        };
    }

    public static Computer Prototype() {
        return new Computer {
            Case = new Case { 
                Manufacturer = "DesignLian Li", 
                Form = "Full towel" 
            },
            Cpu = new Cpu {
                Manufacturer = "Intel",
                Frequency = 1.6
            },
            Gpu = new Gpu { 
                Manufacturer = "Intel", 
                Model = "Arc <Battlemage>"
            },
            Ram = new Ram {
                Manufacturer = "Samsung",
                Volume = 16
            },
            Hdd = new Hdd {
                Manufacturer = "Western Digital",
                Type = "SSD"
            },
            Motherboard = new Motherboard {
                Manufacturer = "Gigabyte",
                Chipset = "H510"
            },
            Monitor = new Monitor {
                Manufacturer = "Asus",
                Resolution = 24
            }
            
        };
    }
}