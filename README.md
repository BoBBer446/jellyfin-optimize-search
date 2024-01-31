Gerne, hier ist ein Entwurf für eine README-Datei, die erklärt, wozu das Custom Search Plugin für Jellyfin dient, einschließlich eines Dateibaums:

---

# Custom Search Plugin für Jellyfin

## Überblick

Das Custom Search Plugin ist ein Erweiterungsmodul für den Jellyfin Media Server, das die Suche nach Medieninhalten verbessert. Es ermöglicht Benutzern, spezifische Muster und Wörter zu definieren, die bei der Suche nach Medientiteln ignoriert oder ersetzt werden sollen. Dies ist besonders nützlich, um Dateinamen zu bereinigen, die häufig Zusatzinformationen wie Format, Sprache oder andere Metadaten enthalten.

## Features

- **Ignorieren bestimmter Wörter:** Benutzer können Wörter oder Phrasen definieren, die bei der Suche ignoriert werden sollen.
- **Anpassbare Ersetzungsregeln:** Möglichkeit, Zeichen oder Zeichenfolgen durch andere zu ersetzen, z. B. das Ersetzen von Punkten durch Leerzeichen.
- **Benutzerfreundliche Konfiguration:** Einstellungen können direkt über die Jellyfin-Oberfläche angepasst werden.

## Dateibaum

```
JellyfinCustomSearch/
├── CustomSearchHandler.cs      # Logik zur Anpassung der Suche
├── Plugin.cs                   # Hauptdatei des Plugins
├── Settings.cs                 # Einstellungen für das Plugin
├── ConfigurationPage.cs        # Konfigurationsseite des Plugins
├── CustomSearchConfigPage.html # HTML-Seite für die Plugin-Konfiguration
└── manifest.json               # Beschreibung und Metadaten des Plugins
```

## Installation

1. **Plugin kompilieren:** Das Plugin muss zuerst kompiliert und als DLL-Datei erstellt werden.
2. **Plugin hinzufügen:** Die erstellte DLL-Datei muss im `plugins`-Verzeichnis des Jellyfin-Servers platziert werden.
3. **Server neu starten:** Nach dem Hinzufügen des Plugins muss der Jellyfin-Server neu gestartet werden.
4. **Konfigurieren:** Das Plugin kann über die Jellyfin-Weboberfläche konfiguriert werden.

## Konfiguration

Nach der Installation erscheint eine neue Konfigurationsseite in der Jellyfin-Oberfläche, auf der Benutzer die Einstellungen des Plugins anpassen können. Hier können Benutzer Wörter definieren, die ignoriert werden sollen, und Regeln für die Ersetzung von Zeichen oder Zeichenfolgen festlegen.

## Lizenz
MIT License

Copyright (c) 2024

Hiermit wird unentgeltlich jeder Person, die eine Kopie der Software und der zugehörigen Dokumentationsdateien (die "Software") erhält, die Erlaubnis erteilt, uneingeschränkt zu nutzen, inklusive ohne Einschränkung der Rechte zum Verwenden, Kopieren, Ändern, Zusammenführen, Veröffentlichen, Verteilen, Unterlizenzieren und/oder Verkaufen von Kopien der Software, und Personen, denen die Software zur Verfügung gestellt wird, dies unter den folgenden Bedingungen zu gestatten:

Der obige Urheberrechtshinweis und dieser Erlaubnishinweis sind in allen Kopien oder wesentlichen Teilen der Software beizulegen.

DIE SOFTWARE WIRD OHNE JEDE AUSDRÜCKLICHE ODER IMPLIZIERTE GARANTIE ZUR VERFÜGUNG GESTELLT, EINSCHLIESSLICH DER GARANTIE ZUR BENUTZUNG FÜR DEN VORGESEHENEN ZWECK UND NICHTVERLETZUNG VON RECHTEN DRITTER. IN KEINEM FALL SIND DIE AUTOREN ODER COPYRIGHTINHABER FÜR IRGENDWELCHE ANSPRÜCHE, SCHÄDEN ODER ANDERE VERPFLICHTUNGEN HAFTBAR, OB IN EINEM VERTRAG, EINEM DELIKT ODER ANDEREN KLAGEGRÜNDEN, DIE AUS, UNTER ODER IN VERBINDUNG MIT DER SOFTWARE ODER DER NUTZUNG ODER ANDEREN GESCHÄFTEN MIT DER SOFTWARE ENTSTEHEN.


