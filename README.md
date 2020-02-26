# Probeaufgabe 1 - TreeView

In einer WebApp soll eine TreeView Komponente implementiert werden. Die Komponente soll hierarchisch aufgebaute Daten direkt im Frontend anzeigen mit Hilfe der Library [jsTree](https://www.jstree.com/docs).

Es exisitert bereits ein [Service](Services/DataService.cs), um Testdaten abrufen zu können. Der [Service](Services/DataService.cs) liefert die Daten in einer flachen Hierarchie, es besteht noch eine Child-Parent Realationship. Alle zurückgelieferten Daten sind Instanzen der Klasse [DataModel](Models/DataModel.cs) verwendet.

## 1. Zielsetzung

Aus Performancegründen sollen die Daten im Backend entsprechend aufbereitet werden und anschließend nur noch im Frontend gerendet werden.

Der [Service](Services/DataService.cs) soll erweitert werden, damit er die Daten hierarchisch aufbaut und an das Frontend ausgibt. Der Aufbau der Hierachie soll sich anhand der Funktion

```cpp
CodingContext.Services.DataService.GetGrouping()
```

zurückgegebenen Gruppierung erfolgen. Die Reihenfolge muss eingehalten werden.

1. Implementierung einer Funktion in [DataService](Services/DataService.cs) zur Erstellung der Hierarchie
2. Ausgeben der Daten im Frontend an der zugehörigen [Stelle](Views/Home/Index.cshtml) unter Verwendung von [jsTree](https://www.jstree.com/docs).
3. Implementierung zweier Buttons, um Daten aus der linken TreeView in die rechte zu transportieren, an der vorgebenen [Stelle](Views/Home/Index.cshtml).
4. Wenn Daten von der linken in die rechte TreeView transport werden, muss dies serverseitig geschehen, es müssen also hierarchische Daten für die linke und die rechte TreeView vom Backend geliefert werden.

## 2. Design

Das Design / Layout existiert bereits.

## 3. Implementierung

Die Implementierung muss anahnd der unter 1. Zielsetzung erforderlichen Punkte erfolgen.

Der [DataService](Services/DataService.cs) soll nur um die benötigten Funktionen erweitert werden, eine Anpassung von den bereits bestehenden Funktionen darf nicht erfolgen. Alle Funktionen sollen rein im Backend implementiert werden, Grouping / Sorting etc. darf nicht im Frontend implementiert werden.

### 3.1 Einsatz von 3rd Party Libraries

Der Einsatz von weiteren Third-Party Libraries ist nicht gewünscht bzw. erforderlich.

### 3.2 Wartbarkeit

Bei der Umsetzung ist gut strukturierter und dokumentierter Code wichtig. Die Einhaltung von gängigen **Best Practises** und **Coding-Style-Guidelines** (abhängig von der jeweils eingesetzen Sprache / Technology) sind gewünscht.

Dein Code soll gut **lesbar** und **verständlich** sein - auch für dritte. Auch der Programmablauf soll nachvollziehbar sein.

Behalte im Hinterkopf, dass du und/oder andere auf dieser Code-Basis aufsetzen und das Projekt erweitern müssen.

## 4. Bereitstellung

Wenn du der Aufgabe fertig bist - oder nur einen Teil in der angegeben Zeit geschafft hast, kannst du uns dein Arbeitsergebnis wie folgt bereitstellen:

1. Stelle uns den Link zu deinem Code-Repository zur Verfügung
   - Falls du noch keines hast, kannst du bei den führenden Anbietern (z.B. [GitHub](https://github.com/), [GitLab](https://about.gitlab.com/), [Bitbucket](https://bitbucket.org/), [AzureDevOps](https://dev.azure.com/), ...) einen Account erstellen und dort dein Projekt bereitstellen.
   - Bitte sorge dafür, dass die Sichtbarkeit des Repositories auf "Public" steht

2. Wenn du eine Demo deines Projektes bereitstellen möchtest, bietet [GitHub Pages](https://pages.github.com/) einen einfachen weg.
