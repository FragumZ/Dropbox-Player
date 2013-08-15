Dropbox Player
==============


[![Still Maintained](http://stillmaintained.com/GrahamCampbell/Dropbox-Player.png)](http://stillmaintained.com/GrahamCampbell/Dropbox-Player)


[![Bitdeli Badge](https://d2weczhvl823v0.cloudfront.net/GrahamCampbell/dropbox-player/trend.png)](https://bitdeli.com/free "Bitdeli Badge")


Copyright © [Graham Campbell](https://github.com/GrahamCampbell) 2013  



## What Is Dropbox Player?

Dropbox Player is a quick experiment with Dropbox API with vb.net.  

* Dropbox Player was created by, and is maintained by [Graham Campbell](https://github.com/GrahamCampbell).  
* Dropbox Player is licensed under the MIT, available [here](https://github.com/GrahamCampbell/Dropbox-Player/blob/master/LICENSE.md).  


## Compiling The Source

The latest and greatest source can be found on [GitHub](https://github.com/GrahamCampbell/Dropbox-Player).  

* Download the source from this repo, either with git or as a zip/tarball.  
* [Visual Studio 2012](http://www.microsoft.com/visualstudio/) is required to compile the source.  
* With [Visual Studio](http://www.microsoft.com/visualstudio/), open as a project and build as usual.  


## Updating Your Fork

Before submitting a pull request, you should ensure that your fork is up to date.  

You may fork Dropbox Player:  

    git remote add upstream git://github.com/GrahamCampbell/Dropbox-Player.git

The first command is only necessary the first time. If you have issues merging, you will need to get a merge tool such as [P4Merge](http://perforce.com/product/components/perforce_visual_merge_and_diff_tools).  

You can then update the branch:  

    git pull --rebase upstream master
    git push --force origin <branch_name>

Once it is set up, run `git mergetool`. Once all conflicts are fixed, run `git rebase --continue`, and `git push --force origin <branch_name>`.  


## License

The MIT License (MIT)

Copyright (c) 2013 Graham Campbell

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
