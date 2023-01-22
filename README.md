# fata-morgana-requiem-remastered-english

English patch for The House in Fata Morgana - A Requiem for Innocence - Remastered. Based on the PS4 version of "The House in Fata Morgana Dreams of the Revenants Edition", re-enabling disabled english files that already exist in the game, as well a tiny bit of original work. This is still just merely an English patch for The House in Fata Morgana - A Requiem for Innocence - Remastered only with the help of assets from that PS4 game, it does not include reincarnation, or the short stories.

Unlike the base game (which I also have a patch for [here](https://github.com/evangelos-ch/fata-morgana-remastered-english)), the PC version of The House in Fata Morgana - A Requiem for Innocence - Remastered also had a few issues even in the un-modded Japanese version which I do fix in this patch:

- Mouse support. Yes, somehow it got released without having proper mouse support like the base game. Primarily with clicking to progress the text.
- A crash in the final story due to a missing image.

Everything in the game including scripts, images and menus is translated based on the official translation of the game by MangaGamer. You can think of this patch as a port of that translation to the Remastered PC version if the game if you will.

The game can be obtained [here](https://www.animategames.jp/home/detail/30083), they seem to accept western cards (or at least they did mine) so long as you have a Japanese IP (you can use a VPN). Note that new account creation seems to require a Japanese SIM card. Please buy it to support Novectacle. Likewise please buy the official HD localized version (PS4 or PS Vita).

## Install

1. Download the latest [Release](https://github.com/evangelos-ch/fata-morgana-requiem-remastered-english/releases).
2. Unzip its contents into the root of the install directory for The House in Fata Morgana - A Requiem for Innocence - Remastered and accept to overwrite existing files when asked.

The game should now be fully in English. You can change the language between Japanese and English in the Config from the main menu.

## Build

This is only if you're curious as to how you could build the patch yourself if you have the PS4 files.

0. You'll need a dump of the PS4 version of "The House in Fata Morgana Dreams of the Revenants Edition". You'll also need to unpack it with a tool of your choice then unpack the `bgimage` AssetBundle. I used [AssetRipper](https://github.com/AssetRipper/AssetRipper). You can put all the PNGs in `Fata Morgana - A Requiem for Innocence - Remastered English Patch/Assets/fata_unity/AssetBundleResources/data/bgimage` or just the ones referenced in [bgimage.json](https://github.com/evangelos-ch/fata-morgana-requiem-remastered-english/blob/master/Fata%20Morgana%20-%20A%20Requiem%20for%20Innocence%20-%20Remastered%20English%20Patch/Assets/Editor/bgimage_en.json).
1. Grab Unity 2017.4.33f1
2. Open `Fata Morgana - A Requiem for Innocence - Remastered English Patch` as a Unity project.
3. Build the AssetBundles with `Project > Build AssetBundles`.
4. The `build` directory should now have the full patch build!

Code changes to `Assembly-CSharp.dll` were rather minimal and were done with [dnSpyEx](https://github.com/dnSpyEx/dnSpy).

## Credits

- **Hacking**: @RainAnnen, @TheZombieKiller
- **Special thanks**: @SomeAnonDev

## Disclaimer

I do not own any of the assets that appear anywhere.
