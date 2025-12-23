
# Viking-Village-URP-U6  

**KellyCode December 8 '25**  

Viking Village URP Upgraded to Unity 6000.0.62f1  

Updated for the Unity Community and otherwise not currently working on this.  It works now but I recommend removing the Boat Attack water Prefab and using a different water such as the extremely nice for the price "URP Water" by YAN VERDE.  Otherwise everything else is very well done - particularly for a free asset.

Builds tested in the Unity Editor and for WebGL and both work without problems.  For the Github upload I switched out some of the huge tif images for png.  All tif images should be replaced and the project has considerable room for optimization.  

## **Build breakers fixed:**  

Unity 6 Build breaking code lived in the Boat Attack Water System in WaterCommon.hlsl (DirectBRDF typo) and WaterSystemFeatures.cs (Required updates and RTHandle fixes based on SnarkyPixel's recommendations (https://discussions.unity.com/t/rendertargethandle-is-obsolete-deprecated-in-favor-of/865093/2))  

Reviewed the Boat Attack code and replacing it with a modern URP water system is my recommendation.

## **Old Boat Attack code caused warnings, mostly for deprecated code, but not build breakers - added [Obsolete] attributes as needed**  

modified:   Assets/UniversalRenderPipelineGlobalSettings.asset
modified:   Assets/Viking Village/Boat Attack Water System/Scripts/Rendering/PlanarReflections.cs
modified:   Assets/Viking Village/Boat Attack Water System/Scripts/Rendering/WaterSystemFeature.cs
modified:   Assets/Viking Village/Boat Attack Water System/Scripts/Water.cs
modified:   Assets/Viking Village/Rendering/VikingVillageUniversal.asset

## None Boat Attack Related Warnings:  

**Self-Intersecting Polygons in FBX models (can be ignored)**  

A polygon of Mesh 'build_small_house_01' in Assets/Viking Village/Models/Buildings/build_small_house_01_low.FBX is self-intersecting and has been discarded.  

A polygon of Mesh 'build_boat_scaffold_01_collider' in Assets/Viking Village/Models/Buildings/build_boat_01.FBX is self-intersecting and has been discarded.  

A polygon of Mesh 'build_boat_scaffold_01_collider' in Assets/Viking Village/Models/Props/prop_scaffold_01.fbx is self-intersecting and has been discarded.  

A polygon of Mesh 'prop_fish_01' in Assets/Viking Village/Models/Props/prop_fish_01.fbx is self-intersecting and has been discarded.  

A polygon of Mesh 'build_bighouse_01' in Assets/Viking Village/Models/Buildings/build_bighouse_01_low.fbx is self-intersecting and has been discarded.  

A polygon of Mesh 'build_barracks_01' in Assets/Viking Village/Models/Buildings/build_barracks_01_low.fbx is self-intersecting and has been discarded.  

A polygon of Mesh 'build_boat_scaffold_01' in Assets/Viking Village/Models/Buildings/build_boat_01_low.FBX is self-intersecting and has been discarded.  

A polygon of Mesh 'build_bighouse_02' in Assets/Viking Village/Models/Buildings/build_bighouse_02_low.FBX is self-intersecting and has been discarded.  

A polygon of Mesh 'build_barracks_single_01' in Assets/Viking Village/Models/Buildings/build_barracks_single_01_low.fbx is self-intersecting and has been discarded.  

A polygon of Mesh 'build_blacksmith_01' in Assets/Viking Village/Models/Buildings/build_blacksmith_01_low.fbx is self-intersecting and has been discarded.  

A polygon of Mesh 'build_small_house_straw_roof_01' in Assets/Viking Village/Models/Buildings/build_small_house_straw_roof_01_low.FBX is self-intersecting and has been discarded.  

A polygon of Mesh 'build_small_house_tall_roof_01' in Assets/Viking Village/Models/Buildings/build_small_house_tall_roof_01_low.FBX is self-intersecting and has been discarded.  





