using System;

public class TCP
{
   public static string TraverseStates(string[] events)
   {
       var state = "CLOSED"; // initial state, always
       for (int i = 0; i < events.Length; ++i) {
         state = MoveToNextState(state, events[i]);
         if (state == "ERROR") return state;
       }

       return state;
   }

    private static string MoveToNextState(string currState, string nextState) {
      switch (currState) {
          case "CLOSED":
            switch (nextState) {
                case "APP_PASSIVE_OPEN":   return "LISTEN";
                case "APP_ACTIVE_OPEN":    return "SYN_SENT";
                default:                   return "ERROR";
            }
          case "LISTEN":
            switch (nextState) {
                case "RCV_SYN":            return "SYN_RCVD";
                case "APP_SEND":           return "SYN_SENT";
                case "APP_CLOSE":          return "CLOSED";
                default:                   return "ERROR";
            }
          case "SYN_RCVD":
            switch (nextState) {
                case "APP_CLOSE":          return "FIN_WAIT_1";
                case "RCV_ACK":            return "ESTABLISHED";
                default:                   return "ERROR";
            }
          case "SYN_SENT":
            switch (nextState) {
                case "RCV_SYN":            return "SYN_RCVD";
                case "RCV_SYN_ACK":        return "ESTABLISHED";
                case "APP_CLOSE":          return "CLOSED";
                default:                   return "ERROR";
            }
          case "ESTABLISHED":
            switch (nextState) {
                case "APP_CLOSE":          return "FIN_WAIT_1";
                case "RCV_FIN":            return "CLOSE_WAIT";
                default:                   return "ERROR";
            }
          case "FIN_WAIT_1":
            switch (nextState) {
                case "RCV_FIN":            return "CLOSING";
                case "RCV_FIN_ACK":        return "TIME_WAIT";
                case "RCV_ACK":            return "FIN_WAIT_2";
                default:                   return "ERROR";
            }
          case "CLOSING":
            switch (nextState) {
                case "RCV_ACK":            return "TIME_WAIT";
                default:                   return "ERROR";
            }
          case "FIN_WAIT_2":
            switch (nextState) {
                case "RCV_FIN":            return "TIME_WAIT";
                default:                   return "ERROR";
            }
          case "TIME_WAIT":
            switch (nextState) {
                case "APP_TIMEOUT":        return "CLOSED";
                default:                   return "ERROR";
            }
          case "CLOSE_WAIT":
            switch (nextState) {
                case "APP_CLOSE":          return "LAST_ACK";
                default:                   return "ERROR";
            }
          case "LAST_ACK":
            switch (nextState) {
                case "RCV_ACK":            return "CLOSED";
                default:                   return "ERROR";
            }
          default:                         return "ERROR";
      }
    }
}
