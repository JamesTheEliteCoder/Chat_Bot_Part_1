*Basic Chat System (InvokeChat)

The first working version of the chatbot was built using a loop-based structure:

InvokeChat() handled continuous user interaction
Basic keyword detection like “password”, “phishing”, “browse”)
Simple Console.WriteLine() responses

At this point, the chatbot was functional but very plain and lacked engagement.

*Introduced Animated Typing (TypeText)

To improve user experience, a custom method called TypeText() was developed.

Improvements added:
Character-by-character typing animation
Word wrapping for long messages
Adjustable line width for better readability

This made the chatbot feel more like a real assistant rather than a static console program.

* Added Color & Personality 
To enhance visual clarity, console colors were introduced:

Bot messages were styled using colored output (cyan)
Different message types could be visually distinguished
Improved readability and user engagement

This gave the chatbot a more “AI-like” presence.

* UI Structuring (Dividers & Headers)
To improve structure and readability, UI formatting elements were introduced:

Features added:
PrintDivider() method for separating sections
Responsive divider width using Console.WindowWidth
Section-based formatting for conversation flow

This made the console feel more like a structured interface rather than raw text output.

* Enhancing Realism 
The typing system was upgraded to feel more natural:

Improvements:
Smooth character-by-character animation
Pause delays after punctuation:
Full stops (.)
Commas (,)
Exclamation/question marks (! ?)

This created a more human-like conversational flow.

* UI Styling Improvements
Further enhancements were added to improve aesthetics:

Divider color changed to magenta (pink-style appearance)
Consistent bot text coloring system
Clean separation between messages and responses

These changes improved the overall visual identity of the chatbot.

* Final Chatbot Logic

The final version of InvokeChat() includes:
Keyword-based response system
Cybersecurity education topics:
Password security
Phishing awareness
Safe browsing habits
General digital safety
Exit handling
Suggested questions for user guidance

The chatbot now provides a structured and guided learning experience.

*Key Features
*Interactive console chatbot
*Smooth animated typing effect
*Colored bot output for readability
* Responsive console UI (dynamic dividers)
* Cybersecurity awareness content
* Modular design (methods like TypeText, PrintDivider, etc.)
* Technologies Used
*C# (.NET Console Application)
*Object-Oriented Programming principles
*Console UI manipulation
*Basic natural language keyword handling
  
**Final Outcome

The project evolved from a simple console-based Q&A system into a structured, animated, and visually enhanced chatbot that simulates a more realistic conversational experience.
It demonstrates:
*Progression in UI design thinking
*Improved user experience techniques
*Practical application of C# console capabilities


