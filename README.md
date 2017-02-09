# Een Balloon-class

features:

- 3 constructors
- random diameter en positie
- `Move()`- en `Grow()`-method
- ...

TODO:

- [x] verplaats random generator van `Balloon` naar `MainWindow`
	- een `Balloon` zou eigenlijk niet zelf verantwoordelijk moeten zijn waar hij geplaatst wordt,
	  de aanroeper (`MainWindow`) zou dit moeten beslissen
- [x] zorg dat oude ballonnen verdwijnen bij init
- [x] achtergrondkleur
	- elke ballon heeft een vaste achtergrondkleur
- [ ] elke ballon heeft de tekst *Happy Birthday*
	- als `Move()` of `Grow()` wordt aangeroepen, verplaatst het `TextBlock` mee
- [ ] maak properties:
	- `Text` : hiermee kan de tekst van een `Balloon` worden aangepast, ook nadat hij getekend is
	- `BackgroundColor` : de achtergrondkleur aanpassen
- [ ] ...
