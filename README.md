# GitLink

GitLink is a simple Windows systray application that ensures unidirectional replication between two directories, including their subdirectories. GitLink is developped under Visual Studio 2017 Community.

                                                               
PURPOSE

Using the exclude file and directory option, GitLink can be usefull to replicate "Link" only some files between two local "Git" repositories. For example, the source directory can contain private and public files pushed to a private Bitbucket account while the target directory contains only public files pushed to a public GitHub account.

Replication is forced at launch to ensure valid state in case of modifications since last run. Note that files and directories deleted in the source directories before the launch of GilLink will not be erased from the target directories. If any, you have to erase them manually. Then replication is procedeed in real time. If an error occurs during replication, the systray icon goes red. When forcing the replication using the context menu associated with the systray icon, the icon goes green if the replication succeed, or stay red instead.

You can see the last 1000 replication events (or error message) in the configuration GitLink form. Excluded files and directories must be separated with "|" character. Exclusion of .git directory is hard coded.

                                                               
IMPORTANT

GitLink is not a backup application, every file deleted from the source directory is instantly deleted in the target directory. Furthermore, to avoid some major risks, some target directories are refused (whole disk like C:\, and system directories like C:\\Windows, C:\\Program*). However, GitLink can protect your files against a disk failure if you have placed the source and target directory on different disk drives.

                                                               
DISCLAIMER

This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License version 3 as published by the Free Software Foundation.

This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.

You should have received a copy of the GNU General Public License along with this program. If not, see <http://www.gnu.org/licenses/>.

                                                               
RELEASE NOTES

Version 1.0	Initial release.

Version 1.1	Fix some bugs in real time filtering process.