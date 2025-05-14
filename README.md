# MixedRealityEffects

# Overview / Ülevaade

### ENG

This repository was created while exploring mixed reality possibilities and functions on Meta Quest 3. Mainly it focuses on visual effects that could be created using Meta Quest 3 Passthrough API and Passthrough Camera API. Repository is divided into two separated projects, where one project is made with Unreal Engine 5 and second one with Unity. Both projects are based on Meta's provided samples. Using already set up projects minimizes risk of unexpected errors and problems.

An overview of each project is also provided, and created samples are included.

### EST

See repositoorium loodi Meta Quest 3 segareaalsuse võimaluste ja funktsioonide uurimise käigus. Peamiselt keskendub see visuaalsetele efektidele, mida saab luua Meta Quest 3 Passthrough API ja Passthrough Camera API abil. Repositoorium on jagatud kaheks eraldi projektiks, kus üks projekt on tehtud Unreal Engine 5-ga ja teine ​​Unityga. Mõlemad projektid põhinevad Meta esitatud näidistel. Juba seadistatud projektide kasutamine vähendab ootamatute vigade ja probleemide riski. 

Edasi on antud ka ülevaade igast projektist eraldi ning lisatud valminud näidiseid.

## Unreal Engine 5

### ENG

Project is based on [Unreal-PassthroughSample](https://github.com/oculus-samples/Unreal-PassthroughSample) and focuses on testing and creating different visual effects using Passthrough API.

### EST

Projekt põhineb [Unreal-PassthroughSample](https://github.com/oculus-samples/Unreal-PassthroughSample) ja keskendub erinevate visuaalsete effektide testimisel ja loomisel kasutades Passthrough API.

### Samples / Näidised

**Edge rendering**

| Only black edges | Only white edges | Changing color edges |
|:-------------:|:--------------------:|:---------------------:|
| ![GIF 1](./Media/BlackEdgesGif.gif) | ![GIF 2](./Media/WhiteEdgesGif.gif) | ![GIF 3](./Media/ColorChangingEdgesGif.gif) |

**ENG**

- Only black edges - created using OculusXRPassthroughLayer's edge rendering and color mapping / adjustment functionality.
- Only white edges - created using OculusXRPassthroughLayer's edge rendering and color mapping / adjustment functionality, but inversed.
- Changing color edges - created using OculusXRPassthroughLayer's edge rendering. Edge color was modified by using randomly created RGBA color.

**EST**

- Only black edges (Ainult mustad ääred) - loodud kasutades OcuculusXRPassthroughLayeri äärte renderdamise ja värvi kaardistamise / reguleerimise funktsionaalsust.
- Only white edges (Ainult valged ääred) - loodud kasutades OcuculusXRPassthroughLayeri äärte renderdamise ja värvi kaardistamise / reguleerimise funktsionaalsust, aga vastupidi.
- Changing color edges (Värvi muutvad ääred) - loodud kasutades OcuculusXRPassthroughLayeri äärte renderdamist. Äärte värv oli muudetud kasutades suvalise RGBA värvi loomist.

**LUT effects**

| RefFlip LUT | RedFlip LUT changing weights | Different LUT effects |
|:-------------:|:--------------------:|:---------------------:|
| ![GIF 4](./Media/RedFlipLUTGif.gif) | ![GIF 5](./Media/RedFlipLUTChangingGif.gif) | ![GIF 6](./Media/DifferentLUTGif.gif) |

**ENG**

- RedFlip LUT - created using OculusXRPassthroughLayer's color mapping functionality which was set to Color LUT type and RedFlip was given as a source.
- RedFlip LUT changing weights - created using OculusXRPassthroughLayer's color mapping functionality which was set to Color LUT type and RedFlip was given as a source. LUT effect's weight was changed using weight changing functionality with randomly generated float number.
- Different LUT effects - created using OculusXRPassthroughLayer's color mapping functionality, where multiple LUT sources were given to demonstrate different LUT effects.

**EST**

- RedFlip LUT - loodud kasutades OculusXRPassthroughLayeri värvide kaardistamise funktsiooni, mille tüübiks määrati Color LUT ja allikaks anti RedFlip.
- RedFlip LUT changing weights - loodud kasutades OculusXRPassthroughLayeri värvide kaardistamise funktsiooni, mille tüübiks määrati Color LUT ja allikaks anti RedFlip. LUT efekti kaalu muudeti juhuslikult genereeritud ujukarvuga kaalu muutmise funktsiooni abil.
- Different LUT effects - loodud kasutades OculusXRPassthroughLayeri värvide kaardistamise funktsiooni, kus erinevate LUT efektide demonstreerimiseks anti erinevaid LUT allikaid.

**Color adjustment / Grayscale color mapping**

| Grayscale color mapping | Color changing | Horror effect |
|:-------------:|:--------------------:|:---------------------:|
| ![GIF 7](./Media/GrayScaleGif.gif) | ![GIF 8](./Media/ColorChangingGif.gif) | ![GIF 9](./Media/HorrorEffectGif.gif) |

**ENG**

- Grayscale color mapping - created using OculusXRPassthroughLayer's color mapping functionality, where color mapping type was set to Grayscale To Color and also parameteres such as brightness and posterization were adjusted.
- Color changing - created using OculusXRPassthroughLayer's color mapping functionality, where RGBA color parameters were adjusted by giving randomly created RGBA color. Also for more interesting effect edge rendering was turned on aswell with given random RGBA color.
- Horror effect - created using OculusXRPassthroughLayer's color mapping functionlity, where parameters such as brightness, contrast and saturation were adjusted.

**EST**

- Grayscale color mapping - loodud kasutades OculusXRPassthroughLayeri värvide kaardistamise funktsiooni, kus värvide kaardistamise tüübiks määrati Grayscale To Color ning kohandati ka selliseid parameetreid nagu heledus ja postereerimine.
- Color changing - loodud kasutades OculusXRPassthroughLayeri värvide kaardistamise funktsiooni, kus RGBA värviparameetreid kohandati juhuslikult loodud RGBA värvi andmisega. Samuti huvitavama efekti huvides lülitati sisse ka servade renderdamine antud suvalise RGBA värviga.
- Horror effect - loodud OculusXRPassthroughLayeri värvide kaardistamise funktsiooni abil, kus reguleeriti selliseid parameetreid nagu heledus, kontrastsus ja küllastus.

**Layer placement**

| Layer placement |
|:-------------:|
| ![GIF 10](./Media/LayerPlacementGif.gif) |

**ENG**

- Layer placement - created using OculusXRPassthroughLayer's layer placement functionality, where Passthrough layer could be placed as underlay so virtual objects could be seen or Passthrough layer could be placed as overlay and virtual objects are hidden from user.

**EST**

- Layer placement - loodud kasutades OculusXRPassthroughLayeri kihtide paigutuse funktsionaalsust, kus Passthrough kihti saab asetada aluskattena, et oleks näha virtuaalseid objekte või Passthrough kihti saab asetada ülekattena ja virtuaalsed objektid on kasutaja eest peidetud.

## Unity

### ENG

Project is based on [Unity-PassthroughCameraApiSamples](https://github.com/oculus-samples/Unity-PassthroughCameraApiSamples.git) and is using given prefabs and examples to access Passthrough Camera data. Project focuses on creating different effects using shaders and also testing Sentis with pretrained model.

### EST

Projekt põhineb [Unity-PassthroughCameraApiSamples](https://github.com/oculus-samples/Unity-PassthroughCameraApiSamples.git) ning kasutab Passthrough Camera andmetele juurdepääsuks etteantud eelseadmeid ja näiteid. Projekt keskendub erinevate efektide loomisele shaderite abil ning Sentise testimisele eeltreenitud mudeliga.

### Samples / Näidised


| Pixelated | Waving |
|:-------------:|:--------------------:|
| ![GIF 11](./Media/PixelatedGif.gif) | ![GIF 12](./Media/WavingGif.gif) |
| Twirl | Hand detection |
| ![GIF 13](./Media/TwirlGif.gif) | ![GIF 14](./Media/HandGif.gif) |


**ENG**

- Pixelated, Waving, Twirl - created using a configured shader graphs, from which a material was created and connected to the object. Using WebCamTextureManager and a helper script, the texture of the Passthrough Camera image was given to the material connected to the object. All these effects were achieved using same method, prefabs, classes and scripts. Only differences that were unique for every effect are shader graphs and materials, which were created using Unity's built in functionalities.

- Hand detection - created using one of the samples provided from Unity's Sentis sample project [sentis-samples](https://github.com/Unity-Technologies/sentis-samples.git). The sample that was used is named [BlazeHand](https://github.com/Unity-Technologies/sentis-samples/tree/main/BlazeDetectionSample/Hand), which is light-weight hand detection model from Google Research. BlazeHand sample's prefabs, scripts and other necessery data were used to connect this model with Passthrough Camera data. Main script HandDetection.cs was modified to work with texture accessed from WebCamTextureManager class, also some additional adjustment were made for detection marks to show up and work correctly. As a result hand detection model works in real time using Meta Quest 3 Passthrough Camera data and places marks on top of detected hand. There are few known problems like reduced frame-rate and no lines connecting detection marks. Further development could attempt to solve these problems.

**EST**

- Pixelated, Waving, Twirl - loodud kasutades seadistatud shader graphi, millest loodi materjal ja ühendati objektiga. WebCamTextureManageri ja abistava skripti abil anti Passthrough Camera pildi tekstuur objektiga ühendatud materjalile. Kõik need efektid saavutati sama meetodi, prefabide, klasside ja skriptide abil. Ainukesed erinevused, mis olid iga efekti jaoks unikaalsed on shader graphid ja materjalid, mis loodi Unity sisseehitatud funktsionaalsuste abil.

- Hand detection - loodud kasutades üht Unity Sentis näidisprojektist [sentis-samples](https://github.com/Unity-Technologies/sentis-samples.git) saadud näidist. Kasutatud näidis kannab nime [BlazeHand](https://github.com/Unity-Technologies/sentis-samples/tree/main/BlazeDetectionSample/Hand), mis on Google Researchi vähekaaluline käetuvastusmudel. Selle mudeli ühendamiseks Passthrough Camera andmetega kasutati BlazeHandi näidise prefabe, skripte ja muid vajalikke andmeid. Peamist skripti HandDetection.cs muudeti nii, et see töötaks WebCamTextureManageri klassist ligipääsetava tekstuuriga, samuti tehti mõningaid täiendavaid muudatusi, et tuvastamismärgid ilmuksid ja töötaksid õigesti. Selle tulemusena töötab käetuvastusmudel reaalajas, kasutades Meta Quest 3 Passthrough Camera andmeid ja asetab tuvastatud käe peale märgid. On mõned teadaolevad probleemid, nagu vähendatud kaadrisagedus ja tuvastusmärke ühendavate joonte puudumine. Edasine arendus võib püüda neid probleeme lahendada.
