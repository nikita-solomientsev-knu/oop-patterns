namespace PrototypeProject {

    public class PcComponent {
        public string Manufacturer { get; set; }

    }

    public class Case: PcComponent, ICopy<Case> {
        public string Form { get; set; }

        public Case Copy() {
            return (Case) MemberwiseClone();
        }

        public override string ToString() {
            return $"Case: ({Manufacturer}) {Form}";
        }
    }

    public class Cpu: PcComponent, ICopy<Cpu> {
        public int Cores { get; set; }
        public double Frequency { get; set; }

        public Cpu Copy() {
            return (Cpu) MemberwiseClone();
        }

        public override string ToString() {
            return $"CPU: ({Manufacturer}) Cores - {Cores}, Frequency (GHz) = {Frequency}";
        }
    }

    public class Ram: PcComponent, ICopy<Ram> {
        public int Volume;
        
        public Ram Copy() {
            return (Ram) MemberwiseClone();
        }

        public override string ToString() {
            return $"RAM: ({Manufacturer}) {Volume} GiB";
        }
    }

    public class Hdd: PcComponent, ICopy<Hdd> {
        public string Type { get; set; }

        public Hdd Copy() {
            return (Hdd) MemberwiseClone();
        }

        public override string ToString() {
            return $"HDD: ({Manufacturer}) {Type}";
        }
    }

    public class Motherboard: PcComponent, ICopy<Motherboard> {
        public string Chipset { get; set; }

        public Motherboard Copy() {
            return (Motherboard) MemberwiseClone();
        }
        
        public override string ToString() {
            return $"Motherboard: ({Manufacturer}) Chipset - {Chipset}";
        }
    }

    public class Gpu: PcComponent, ICopy<Gpu> {
        public string Model { get; set; }

        public Gpu Copy() {
            return (Gpu) MemberwiseClone();
        }
        
        public override string ToString() {
            return $"GPU: ({Manufacturer}) {Model}";
        }
    }

    public class Monitor: PcComponent, ICopy<Monitor> {
        public int Resolution { get; set; }

        public Monitor Copy() {
            return (Monitor) MemberwiseClone();
        }

        public override string ToString() {
            return $"Monitor: ({Manufacturer}) Diagonal resolution - {Resolution}";
        }
    }
}