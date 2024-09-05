# DataPasta (pronouced "data paster")
DataPasta is a tool to programatically "paste" text into applications and fields that are not copy paste enabled or that block copy and paste, or for red teams to exfiltrate files using programatic keystrokes.

Are you frustrated by password fields that prevent pasting in a password, in a misguided attempt to improve security (that simaltaneuously prevents the use of long complex passwords that you'd otherwise store in your password manager)?  DataPasta overcomes this by emulating the keyboard to type out whatever is on the clipboard.

Additionally, it can aid in transferring files over channels that only allow keystrokes, by typing in the contents of a text file, or even base64 encoding a file and typing out the results for you.  Some data loss prevention tools that monitor data pasted from the clipboard do not monitor data entered as keystrokes.  Data Pasta can be used by security blue teams  to assess the vulnerability of their controls in this regard, and by pen testers to demonstrate the vulnerability.

DataPasta has a compact user interface which appears unobtrusively at the bottom right of the screen, above the system tray.  It has only 3 buttons - type clipboard, type text file, and base64 encode and type file (ok, and yes, for the pedants, a forth button to minimise it to the system tray!).

![Datapasta](https://github.com/user-attachments/assets/a4a0b495-12fa-4286-b507-bbe6f3b9798e)
