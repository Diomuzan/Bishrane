string message = "Find what is (inside the parentheses)";
int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');
openingPosition += 1;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length) + "\n");

string message1 = "Find what is (inside the parentheses)";
int openingPosition1 = message.IndexOf('(');
int closingPosition1 = message.IndexOf(')');
Console.WriteLine(openingPosition1);
Console.WriteLine(closingPosition1 + "\n");
openingPosition1 += 1;
int length1 = closingPosition1 - openingPosition1;
Console.WriteLine(message.Substring(openingPosition1, length1) + "\n");

string message2 = "What is the value <span>between the tags</span>?";
int openingPosition2 = message2.IndexOf("<span>");
int closingPosition2 = message2.IndexOf("</span>");
if (closingPosition2 > openingPosition2){
    openingPosition2 += 6;
    int length2 = closingPosition2 - openingPosition2;
    Console.WriteLine(message2.Substring(openingPosition2, length2));
} else {
    Console.WriteLine("Opening and closing span tags are not properly matched." + "\n");
}

string message3 = "(What if) I am (only interested) in the last (set of parentheses)?";
int openingPosition3 = message3.LastIndexOf('(');
openingPosition3 += 1;
int closingPosition3 = message3.LastIndexOf(')');
int length3 = closingPosition3 - openingPosition3;
Console.WriteLine(message3.Substring(openingPosition3, length3) + "\n");

string message4 = "(What if) there are (more than) one (set of parentheses)?";
int openingPosition4;
while (true) {
    openingPosition4 = message4.IndexOf('(');
    if (openingPosition4 == -1) break;
    int closingPosition4 = message4.IndexOf(')');
    if (closingPosition4 == -1) break;
    int length4 = closingPosition4 - openingPosition4 - 1;
    Console.WriteLine(message4.Substring(openingPosition4 + 1, length4) + "\n");
    message4 = message4.Substring(closingPosition4 + 1);
}

string message5 = "(What if) I am (only interested) in the last (set of parentheses)?";
int openingPosition5 = message5.LastIndexOf('(');
openingPosition5 += 1;
int closingPosition5 = message5.LastIndexOf(')');
int length5 = closingPosition5 - openingPosition5;
Console.WriteLine(message5.Substring(openingPosition5, length5) + "\n");

string message6 = "(What if) there are (more than) one (set of parentheses)?";
while (true) {
    int openingPosition6 = message6.IndexOf('(');
    if (openingPosition6 == -1) break;
    openingPosition6 += 1;
    int closingPosition6 = message6.IndexOf(')');
    int length6 = closingPosition6 - openingPosition6; // Korrigierter Index
    Console.WriteLine(message6.Substring(openingPosition6, length6));
    message6 = message6.Substring(closingPosition6 + 1);
}
