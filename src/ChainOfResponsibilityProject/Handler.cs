namespace ChainOfResponsibilityProject {
    public struct Question {
        public uint priority;
        public string value;
    }

    public class Handler {

        public virtual Handler? GetSuccessor() {
            return null;
        }

        public abstract string? Handle(Question question);

    }

    public class SeniorTechnician: Handler {
        public string? Handle(Question question) {
            if (question.priority < 4) {
                return "Senior response";
            }
            return null
        }
    }

    public class MiddleTechnician: Handler {

        public Handler? GetSuccessor() {
            return new SeniorTechnician();
        }

        public string? Handle(Question question) {
            if (question.priority < 3) {
                return "Middle response";
            }
            return null;
        }
    }

    public class JuniorTechnician: Handler {
        public Handler? GetSuccessor() {
            return new MiddleTechnician();
        }

        public string? Handle(Question question) {
            if (question.priority < 2) {
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
