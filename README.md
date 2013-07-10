Dropbox Player
==============


Copyright © [Graham Campbell](https://github.com/GrahamCampbell) 2013  



## What Is Dropbox Player?

Dropbox Player is a quick experiment with Dropbox API with vb.net.  

* Dropbox Player, in its current form, is maintained by [Graham Campbell](https://github.com/GrahamCampbell).  
* Dropbox Player is licensed under the DBADv1, available [here](https://github.com/GrahamCampbell/Dropbox-Player/blob/master/LICENSE.md).  


## Compiling The Source

The latest and greatest source can be found on [GitHub](https://github.com/GrahamCampbell/Dropbox-Player).  

* Download the source from this repo, either with git or as a zip/tarball.  
* [Visual Studio 2012](http://www.microsoft.com/visualstudio/) is required to compile the source.  
* With [Visual Studio](http://www.microsoft.com/visualstudio/), open as a project and build as usual.  


## Updating Your Fork

Before submitting a pull request, you should ensure that your fork is up to date.  

You may fork the Dropbox Player:  

    git remote add upstream git://github.com/GrahamCampbell/Dropbox-Player.git

The first command is only necessary the first time. If you have issues merging, you will need to get a merge tool such as [P4Merge](http://perforce.com/product/components/perforce_visual_merge_and_diff_tools).  

You can then update the branch:  

    git pull --rebase upstream master
    git push --force origin <branch_name>

Once it is set up, run `git mergetool`. Once all conflicts are fixed, run `git rebase --continue`, and `git push --force origin <branch_name>`.  


## License

Dropbox Player - A Quick Experiment With Dropbox API  
Copyright (C) 2013  Graham Campbell  

This program is free software: you can redistribute it and/or modify it under the terms of the Don't Be A Dick Public License, either version 1 of the License, or (at your option) any later version.  

This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the Don't Be A Dick Public License for more details.  
  
You should have received a copy of the Don't Be A Dick Public License along with this program.  If not, see http://www.dbad-license.org/.  
