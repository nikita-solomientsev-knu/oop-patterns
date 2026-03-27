namespace ChainOfResponsibilityProject {
    public class Question {
        public uint Priority { get; set; }
        public string Value { get; set; }
    }

    public abstract class Handler {

        public virtual Handler? GetSuccessor() {
            return null;
        }

        public abstract string? Handle(Question question);
    }

    public class SeniorTechnician: Handler {
        public override string? Handle(Question question) {
            if (question.Priority < 4) {
                return "Senior response";
            }
            return null;
        }
    }

    public class MiddleTechnician: Handler {

        public override Handler? GetSuccessor() {
            return new SeniorTechnician();
        }

        public override string? Handle(Question question) {
            if (question.Priority < 3) {
                return "Middle response";
            }
            return null;
        }
    }

    public class JuniorTechnician: Handler {
        public override Handler? GetSuccessor() {
            return new MiddleTechnician();
        }

        public override string? Handle(Question question) {
            if (question.Priority < 2) {
                return "Junior response";
            }
            return null;
        }
    }


    public class CallCentre {

        public string? Handle(Question question) {
            string? response = null;
            for (Handler? handler = new JuniorTechnician(); handler != null && response == null; handler = handler.GetSuccessor()) {
                response = handler.Handle(question);
            }
            if (response == null) {
                return "The question had too high priority for the call centre";
            }
            return response;
        }
    }
}
