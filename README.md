--Use this structure for the project--
<br/>
master: only for release<br/>
devel: this is the development branch. This one should always work (tests can’t be broken)<br/>
topic/$name: when we start to develop a new feature, we create a topic branch<br/>
hotfix/$name: when we need to release a new version right now, without merging devel before, we create a hofrix branch<br/>
release/$version: when we’re ready to ship, we create a new branch<br/>
