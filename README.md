# 10-Kinderaddierer-JFruehwirth

### Dev. plattform: 
Unity 2D, Visual Studios 2019;

### Was bauen wir?
Wir wollen Addieraufgaben Kindern vom Alter 6-10 Jahre stellen. Wir wollen eine Willkommenscene, eine Rechenscene und eine Endscene kreiren. In der Rechenscene wollen wir 3 Runden mit jeweils 4 Aufgaben haben. Jede Runde sollte anders von der davor sein.

### Was brauchen wir?
Wir brauchen “using SceneManagement;”, “using UntiyEngine.UI;” und „using UntiyEngine;“, Canvas (Screenindependent), IPF (Inputfield), Image, Tasteninput;

### Aufbau:
+ Scene 1:  Text "Willkommen"
          Name eingeben, Tier auswählen und per Scriptable Object speichern
          mit Leertaste zu Scene 2


+ Scene 2:  Rundenanzahl
          Score der richtig beantworteten Rechnungen
          Name und Tier von Scene 1 übernehmen und anzeigen lassen
          
     Runde 1 (true/false): 
     Zahl + Zahl = Zahl	true / false
           
           
     Runde 2 (Scheiben mit Drag und Drop):
     
     ![Bild_2022-05-05_095616323](https://user-images.githubusercontent.com/100833653/166882851-2dba4e5e-5af4-4f5f-a37a-7b963db45511.png)
          
          
     Runde 3 (Input Fields):
     Zahl + Zahl = Variable
       
       
+ Scene 3:  Motivierende nette Nachricht
          Finaler Punktestand
          Name und Tier von Scene 1 übernehmen und anzeigen lassen
          
