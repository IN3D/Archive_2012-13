Feudal
<hr/>
<b>Alpha build</b>
Feudal is a long term/pet project in C# inspired by many of <a href="http://www.paradoxplaza.com/">Paradox Interactive's</a> games, specifically <a href="http://www.paradoxplaza.com/games/crusader-kings-ii">Crusader Kings 2</a> and <a href="http://www.europauniversalis4.com/">Europa Unversalis 4</a>.<br/>
The game is a menu driven turn-based strategy game, set in an alternative future where humanity is rebuilding itself giving rise to feudal style powers. 

======
--Use this structure for the project--
<br/>
<table>
	<tr>
		master: only for release<br/>
	</tr>
	<tr>
		devel: this is the development branch. This one should always work (tests can’t be broken)<br/>
	</tr>
	<tr>
		topic/$name: when we start to develop a new feature, we create a topic branch<br/>
	</tr>
	<tr>
		hotfix/$name: when we need to release a new version right now, without merging devel before, we create a hotfix branch<br/>
	</tr>
	<tr>
		release/$version: when we’re ready to ship, we create a new branch<br/>
	</tr>
</table>