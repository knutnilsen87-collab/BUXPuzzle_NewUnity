# BUX Developer Folder Overview

Generated: 2026-05-23 22:24:55

Use `Assets/BUX` as the new organized asset root. Gameplay code, project settings, build settings, and existing source assets outside this folder were not modified by this import.

## Important Files
- `Assets/BUX/Data/Manifests/asset_manifest.csv`: visual assets and non-audio package artifacts with source and target paths.
- `Assets/BUX/Data/Manifests/audio_manifest.csv`: audio assets with source and target paths.
- `Assets/BUX/Data/Manifests/import_summary.md`: counts, Unity import recommendations, and every copied file.
- `Assets/BUX/Data/Manifests/missing_assets_report.md`: missing critical PNG/audio groups.
- `Assets/BUX/Data/Manifests/duplicates_report.md`: duplicate/conflict files placed in review.
- `Assets/BUX/_Review`: preserved leftovers, duplicates, unclear generated files, and audio needing rename.

## Folder Tree
```text
Assets/BUX/
|-- _Review/
|   |-- Duplicates/
|   |   |-- BUX2__renamed_unsorted3_assets/
|   |   |   |-- bear_head_tile.png
|   |   |   |-- Cbear1.png
|   |   |   +-- companion_bear_base.png
|   |   |-- blocker_stone_cracked_01.png
|   |   |-- blocker_stone_cracked_02.png
|   |   +-- blocker_stone_full.png
|   |-- MissingExpected/
|   |-- NeedsRename/
|   |   +-- Audio/
|   |       |-- 06.mp3
|   |       |-- 07.mp3
|   |       |-- 08.mp3
|   |       |-- 09.mp3
|   |       |-- 10.mp3
|   |       |-- 11.mp3
|   |       |-- 12.mp3
|   |       |-- 13.mp3
|   |       |-- 14.mp3
|   |       |-- 15. Short Premium Mobile Puzzle Game Victory Stinger. Cozy Magical Forest Sty.mp3
|   |       +-- 31.mp3
|   +-- Unsorted/
|       |-- BOARD.zip
|       |-- BUX_Puzzle_Full_Production_Spec_Aegis_Enhanced.zip
|       |-- BUX_Puzzle_Full_Production_Spec_Filled.zip
|       |-- Gemini_Generated_Image_ (1).png
|       |-- Gemini_Generated_Image_ (1)__conflict_1.png
|       |-- Gemini_Generated_Image_ (1)__conflict_2.png
|       |-- Gemini_Generated_Image_ (1)__conflict_3.png
|       |-- Gemini_Generated_Image_ (1)__conflict_4.png
|       |-- Gemini_Generated_Image_ (1)__conflict_5.png
|       |-- Gemini_Generated_Image_ (10).png
|       |-- Gemini_Generated_Image_ (10)__conflict_1.png
|       |-- Gemini_Generated_Image_ (10)__conflict_2.png
|       |-- Gemini_Generated_Image_ (10)__conflict_3.png
|       |-- Gemini_Generated_Image_ (10)__conflict_4.png
|       |-- Gemini_Generated_Image_ (10)__conflict_5.png
|       |-- Gemini_Generated_Image_ (11).png
|       |-- Gemini_Generated_Image_ (11)__conflict_1.png
|       |-- Gemini_Generated_Image_ (11)__conflict_2.png
|       |-- Gemini_Generated_Image_ (11)__conflict_3.png
|       |-- Gemini_Generated_Image_ (11)__conflict_4.png
|       |-- Gemini_Generated_Image_ (11)__conflict_5.png
|       |-- Gemini_Generated_Image_ (12).png
|       |-- Gemini_Generated_Image_ (12)__conflict_1.png
|       |-- Gemini_Generated_Image_ (12)__conflict_2.png
|       |-- Gemini_Generated_Image_ (12)__conflict_3.png
|       |-- Gemini_Generated_Image_ (12)__conflict_4.png
|       |-- Gemini_Generated_Image_ (12)__conflict_5.png
|       |-- Gemini_Generated_Image_ (13).png
|       |-- Gemini_Generated_Image_ (13)__conflict_1.png
|       |-- Gemini_Generated_Image_ (13)__conflict_2.png
|       |-- Gemini_Generated_Image_ (13)__conflict_3.png
|       |-- Gemini_Generated_Image_ (13)__conflict_4.png
|       |-- Gemini_Generated_Image_ (13)__conflict_5.png
|       |-- Gemini_Generated_Image_ (14).png
|       |-- Gemini_Generated_Image_ (14)__conflict_1.png
|       |-- Gemini_Generated_Image_ (14)__conflict_2.png
|       |-- Gemini_Generated_Image_ (14)__conflict_3.png
|       |-- Gemini_Generated_Image_ (14)__conflict_4.png
|       |-- Gemini_Generated_Image_ (14)__conflict_5.png
|       |-- Gemini_Generated_Image_ (15).png
|       |-- Gemini_Generated_Image_ (15)__conflict_1.png
|       |-- Gemini_Generated_Image_ (15)__conflict_2.png
|       |-- Gemini_Generated_Image_ (15)__conflict_3.png
|       |-- Gemini_Generated_Image_ (15)__conflict_4.png
|       |-- Gemini_Generated_Image_ (16).png
|       |-- Gemini_Generated_Image_ (16)__conflict_1.png
|       |-- Gemini_Generated_Image_ (16)__conflict_2.png
|       |-- Gemini_Generated_Image_ (16)__conflict_3.png
|       |-- Gemini_Generated_Image_ (16)__conflict_4.png
|       |-- Gemini_Generated_Image_ (17).png
|       |-- Gemini_Generated_Image_ (17)__conflict_1.png
|       |-- Gemini_Generated_Image_ (17)__conflict_2.png
|       |-- Gemini_Generated_Image_ (17)__conflict_3.png
|       |-- Gemini_Generated_Image_ (17)__conflict_4.png
|       |-- Gemini_Generated_Image_ (18).png
|       |-- Gemini_Generated_Image_ (18)__conflict_1.png
|       |-- Gemini_Generated_Image_ (18)__conflict_2.png
|       |-- Gemini_Generated_Image_ (18)__conflict_3.png
|       |-- Gemini_Generated_Image_ (18)__conflict_4.png
|       |-- Gemini_Generated_Image_ (19).png
|       |-- Gemini_Generated_Image_ (19)__conflict_1.png
|       |-- Gemini_Generated_Image_ (19)__conflict_2.png
|       |-- Gemini_Generated_Image_ (19)__conflict_3.png
|       |-- Gemini_Generated_Image_ (19)__conflict_4.png
|       |-- Gemini_Generated_Image_ (2).png
|       |-- Gemini_Generated_Image_ (2)__conflict_1.png
|       |-- Gemini_Generated_Image_ (2)__conflict_2.png
|       |-- Gemini_Generated_Image_ (2)__conflict_3.png
|       |-- Gemini_Generated_Image_ (2)__conflict_4.png
|       |-- Gemini_Generated_Image_ (2)__conflict_5.png
|       |-- Gemini_Generated_Image_ (20).png
|       |-- Gemini_Generated_Image_ (20)__conflict_1.png
|       |-- Gemini_Generated_Image_ (20)__conflict_2.png
|       |-- Gemini_Generated_Image_ (20)__conflict_3.png
|       |-- Gemini_Generated_Image_ (21).png
|       |-- Gemini_Generated_Image_ (21)__conflict_1.png
|       |-- Gemini_Generated_Image_ (21)__conflict_2.png
|       |-- Gemini_Generated_Image_ (21)__conflict_3.png
|       |-- Gemini_Generated_Image_ (22).png
|       |-- Gemini_Generated_Image_ (22)__conflict_1.png
|       |-- Gemini_Generated_Image_ (22)__conflict_2.png
|       |-- Gemini_Generated_Image_ (22)__conflict_3.png
|       |-- Gemini_Generated_Image_ (23).png
|       |-- Gemini_Generated_Image_ (23)__conflict_1.png
|       |-- Gemini_Generated_Image_ (23)__conflict_2.png
|       |-- Gemini_Generated_Image_ (23)__conflict_3.png
|       |-- Gemini_Generated_Image_ (24).png
|       |-- Gemini_Generated_Image_ (24)__conflict_1.png
|       |-- Gemini_Generated_Image_ (24)__conflict_2.png
|       |-- Gemini_Generated_Image_ (24)__conflict_3.png
|       |-- Gemini_Generated_Image_ (25).png
|       |-- Gemini_Generated_Image_ (25)__conflict_1.png
|       |-- Gemini_Generated_Image_ (25)__conflict_2.png
|       |-- Gemini_Generated_Image_ (25)__conflict_3.png
|       |-- Gemini_Generated_Image_ (26).png
|       |-- Gemini_Generated_Image_ (26)__conflict_1.png
|       |-- Gemini_Generated_Image_ (26)__conflict_2.png
|       |-- Gemini_Generated_Image_ (26)__conflict_3.png
|       |-- Gemini_Generated_Image_ (27).png
|       |-- Gemini_Generated_Image_ (27)__conflict_1.png
|       |-- Gemini_Generated_Image_ (27)__conflict_2.png
|       |-- Gemini_Generated_Image_ (27)__conflict_3.png
|       |-- Gemini_Generated_Image_ (28).png
|       |-- Gemini_Generated_Image_ (28)__conflict_1.png
|       |-- Gemini_Generated_Image_ (28)__conflict_2.png
|       |-- Gemini_Generated_Image_ (29).png
|       |-- Gemini_Generated_Image_ (29)__conflict_1.png
|       |-- Gemini_Generated_Image_ (29)__conflict_2.png
|       |-- Gemini_Generated_Image_ (3).png
|       |-- Gemini_Generated_Image_ (3)__conflict_1.png
|       |-- Gemini_Generated_Image_ (3)__conflict_2.png
|       |-- Gemini_Generated_Image_ (3)__conflict_3.png
|       |-- Gemini_Generated_Image_ (3)__conflict_4.png
|       |-- Gemini_Generated_Image_ (3)__conflict_5.png
|       |-- Gemini_Generated_Image_ (30).png
|       |-- Gemini_Generated_Image_ (30)__conflict_1.png
|       |-- Gemini_Generated_Image_ (30)__conflict_2.png
|       |-- Gemini_Generated_Image_ (31).png
|       |-- Gemini_Generated_Image_ (31)__conflict_1.png
|       |-- Gemini_Generated_Image_ (31)__conflict_2.png
|       |-- Gemini_Generated_Image_ (32).png
|       |-- Gemini_Generated_Image_ (32)__conflict_1.png
|       |-- Gemini_Generated_Image_ (32)__conflict_2.png
|       |-- Gemini_Generated_Image_ (33).png
|       |-- Gemini_Generated_Image_ (33)__conflict_1.png
|       |-- Gemini_Generated_Image_ (33)__conflict_2.png
|       |-- Gemini_Generated_Image_ (34).png
|       |-- Gemini_Generated_Image_ (34)__conflict_1.png
|       |-- Gemini_Generated_Image_ (34)__conflict_2.png
|       |-- Gemini_Generated_Image_ (35).png
|       |-- Gemini_Generated_Image_ (35)__conflict_1.png
|       |-- Gemini_Generated_Image_ (35)__conflict_2.png
|       |-- Gemini_Generated_Image_ (36).png
|       |-- Gemini_Generated_Image_ (36)__conflict_1.png
|       |-- Gemini_Generated_Image_ (36)__conflict_2.png
|       |-- Gemini_Generated_Image_ (37).png
|       |-- Gemini_Generated_Image_ (37)__conflict_1.png
|       |-- Gemini_Generated_Image_ (37)__conflict_2.png
|       |-- Gemini_Generated_Image_ (38).png
|       |-- Gemini_Generated_Image_ (38)__conflict_1.png
|       |-- Gemini_Generated_Image_ (38)__conflict_2.png
|       |-- Gemini_Generated_Image_ (39).png
|       |-- Gemini_Generated_Image_ (39)__conflict_1.png
|       |-- Gemini_Generated_Image_ (39)__conflict_2.png
|       |-- Gemini_Generated_Image_ (4).png
|       |-- Gemini_Generated_Image_ (4)__conflict_1.png
|       |-- Gemini_Generated_Image_ (4)__conflict_2.png
|       |-- Gemini_Generated_Image_ (4)__conflict_3.png
|       |-- Gemini_Generated_Image_ (4)__conflict_4.png
|       |-- Gemini_Generated_Image_ (4)__conflict_5.png
|       |-- Gemini_Generated_Image_ (40).png
|       |-- Gemini_Generated_Image_ (40)__conflict_1.png
|       |-- Gemini_Generated_Image_ (40)__conflict_2.png
|       |-- Gemini_Generated_Image_ (41).png
|       |-- Gemini_Generated_Image_ (41)__conflict_1.png
|       |-- Gemini_Generated_Image_ (41)__conflict_2.png
|       |-- Gemini_Generated_Image_ (42).png
|       |-- Gemini_Generated_Image_ (42)__conflict_1.png
|       |-- Gemini_Generated_Image_ (43).png
|       |-- Gemini_Generated_Image_ (43)__conflict_1.png
|       |-- Gemini_Generated_Image_ (44).png
|       |-- Gemini_Generated_Image_ (44)__conflict_1.png
|       |-- Gemini_Generated_Image_ (45).png
|       |-- Gemini_Generated_Image_ (46).png
|       |-- Gemini_Generated_Image_ (5).png
|       |-- Gemini_Generated_Image_ (5)__conflict_1.png
|       |-- Gemini_Generated_Image_ (5)__conflict_2.png
|       |-- Gemini_Generated_Image_ (5)__conflict_3.png
|       |-- Gemini_Generated_Image_ (5)__conflict_4.png
|       |-- Gemini_Generated_Image_ (5)__conflict_5.png
|       |-- Gemini_Generated_Image_ (6).png
|       |-- Gemini_Generated_Image_ (6)__conflict_1.png
|       |-- Gemini_Generated_Image_ (6)__conflict_2.png
|       |-- Gemini_Generated_Image_ (6)__conflict_3.png
|       |-- Gemini_Generated_Image_ (6)__conflict_4.png
|       |-- Gemini_Generated_Image_ (6)__conflict_5.png
|       |-- Gemini_Generated_Image_ (7).png
|       |-- Gemini_Generated_Image_ (7)__conflict_1.png
|       |-- Gemini_Generated_Image_ (7)__conflict_2.png
|       |-- Gemini_Generated_Image_ (7)__conflict_3.png
|       |-- Gemini_Generated_Image_ (7)__conflict_4.png
|       |-- Gemini_Generated_Image_ (7)__conflict_5.png
|       |-- Gemini_Generated_Image_ (8).png
|       |-- Gemini_Generated_Image_ (8)__conflict_1.png
|       |-- Gemini_Generated_Image_ (8)__conflict_2.png
|       |-- Gemini_Generated_Image_ (8)__conflict_3.png
|       |-- Gemini_Generated_Image_ (8)__conflict_4.png
|       |-- Gemini_Generated_Image_ (8)__conflict_5.png
|       |-- Gemini_Generated_Image_ (9).png
|       |-- Gemini_Generated_Image_ (9)__conflict_1.png
|       |-- Gemini_Generated_Image_ (9)__conflict_2.png
|       |-- Gemini_Generated_Image_ (9)__conflict_3.png
|       |-- Gemini_Generated_Image_ (9)__conflict_4.png
|       |-- Gemini_Generated_Image_ (9)__conflict_5.png
|       |-- Gemini_Generated_Image_.png
|       |-- Gemini_Generated_Image___conflict_1.png
|       |-- Gemini_Generated_Image___conflict_2.png
|       |-- Gemini_Generated_Image___conflict_3.png
|       |-- Gemini_Generated_Image___conflict_4.png
|       |-- Gemini_Generated_Image___conflict_5.png
|       |-- Gemini_Generated_Image___conflict_6.png
|       |-- Gemini_Generated_Image___conflict_7.png
|       |-- renamed_unsorted3_assets_contact_sheet.png
|       |-- renamed_unsorted4_assets_contact_sheet.png
|       |-- sprite sheet.png
|       |-- TILES.zip
|       |-- tree.zip
|       |-- unsorted_contact_sheet.png
|       |-- unsorted_new_25_44_contact_sheet.png
|       |-- unsorted_ny_contact_sheet.png
|       |-- unsorted3_contact_sheet.png
|       |-- unsorted3_contact_sheet_write_order.png
|       |-- unsorted4_contact_sheet.png
|       |-- unsorted5_contact_sheet.png
|       +-- unsorted6_contact_sheet.png
|-- Art/
|   |-- Backgrounds/
|   |   |-- Events/
|   |   |   +-- event_honey_harvest_background.png
|   |   |-- Gameplay/
|   |   |   |-- dark_overlay_vignette.png
|   |   |   |-- level_background_berry_village.png
|   |   |   |-- level_background_calm_forest.png
|   |   |   |-- level_background_crystal_garden.png
|   |   |   |-- level_background_honey_hills.png
|   |   |   |-- level_background_magic_clearing.png
|   |   |   |-- level_background_moonlit_grove.png
|   |   |   |-- level_background_mossy_forest.png
|   |   |   |-- level_background_soft_blurred.png
|   |   |   +-- main_forest_background.png
|   |   |-- Meta/
|   |   |   +-- meta_bear_village_background.png
|   |   +-- WorldMaps/
|   |       |-- map_board_world_01_berry_village.png
|   |       |-- map_board_world_02_mossy_forest.png
|   |       |-- map_board_world_03_honey_hills.png
|   |       |-- map_board_world_04_magic_clearing.png
|   |       |-- map_board_world_05_moonlit_grove.png
|   |       +-- map_board_world_06_crystal_garden.png
|   |-- Board/
|   |   |-- Cells/
|   |   |   |-- board_cell_brown.png
|   |   |   +-- board_cells_atlas.png
|   |   |-- Decorations/
|   |   |   +-- board_decorations_atlas.png
|   |   |-- Frames/
|   |   |   |-- board_corner_decoration_top_left.png
|   |   |   |-- board_empty_area.png
|   |   |   |-- board_frame_atlas.png
|   |   |   |-- board_inner_grid_surface.png
|   |   |   +-- wooden_board_frame.png
|   |   |-- ShapeMasks/
|   |   |   +-- board_shape_masks_atlas.png
|   |   +-- Skins/
|   |       |-- challenge_board_skins_atlas.png
|   |       +-- event_board_skins_atlas.png
|   |-- Companion/
|   |   +-- Bear/
|   |       |-- Base/
|   |       |   |-- Cbear1.png
|   |       |   +-- companion_bear_base.png
|   |       |-- Cosmetics/
|   |       |   |-- Accessories/
|   |       |   |   |-- cosmetic_accessory_backpack.png
|   |       |   |   |-- cosmetic_accessory_glasses.png
|   |       |   |   +-- cosmetic_accessory_honey_spoon.png
|   |       |   |-- Body/
|   |       |   |   |-- cosmetic_body_beekeeper_suit.png
|   |       |   |   |-- cosmetic_body_forest_vest.png
|   |       |   |   +-- cosmetic_body_raincoat.png
|   |       |   |-- Hats/
|   |       |   |   |-- cosmetic_hat_beekeeper_hat.png
|   |       |   |   |-- cosmetic_hat_mushroom_cap.png
|   |       |   |   +-- cosmetic_hat_red_cap.png
|   |       |   +-- Neck/
|   |       |       |-- cosmetic_neck_blue_scarf.png
|   |       |       |-- cosmetic_neck_flower_necklace.png
|   |       |       +-- cosmetic_neck_red_scarf.png
|   |       |-- GameplayPoses/
|   |       |   |-- companion_bear_big_cheer.png
|   |       |   |-- companion_bear_defeat_encourage.png
|   |       |   |-- companion_bear_happy.png
|   |       |   |-- companion_bear_hint_point.png
|   |       |   |-- companion_bear_idle.png
|   |       |   |-- companion_bear_surprised.png
|   |       |   |-- companion_bear_victory.png
|   |       |   +-- companion_bear_worried.png
|   |       |-- MapPoses/
|   |       |   |-- companion_bear_map_celebrate.png
|   |       |   |-- companion_bear_map_idle.png
|   |       |   |-- companion_bear_map_open_chest.png
|   |       |   |-- companion_bear_map_walk_01.png
|   |       |   |-- companion_bear_map_walk_02.png
|   |       |   +-- companion_bear_map_wave.png
|   |       +-- desktop.ini
|   |-- Events/
|   |   +-- HoneyHarvest/
|   |       |-- event_board_skins_atlas.png
|   |       |-- event_honey_board_frame.png
|   |       |-- event_honey_chest_closed.png
|   |       |-- event_honey_chest_open.png
|   |       |-- event_honey_harvest_background.png
|   |       |-- event_honey_harvest_button.png
|   |       |-- event_honey_harvest_logo.png
|   |       |-- event_honey_progress_bar.png
|   |       |-- event_honey_reward_track.png
|   |       +-- event_honey_token_large.png
|   |-- Map/
|   |   |-- Gates/
|   |   |   |-- map_world_complete_banner.png
|   |   |   |-- map_world_gate_locked.png
|   |   |   |-- map_world_gate_open.png
|   |   |   +-- map_world_gates_atlas.png
|   |   |-- Nodes/
|   |   |   |-- map_node_challenge.png
|   |   |   |-- map_node_chest.png
|   |   |   |-- map_node_completed_1_star.png
|   |   |   |-- map_node_completed_2_star.png
|   |   |   |-- map_node_completed_3_star.png
|   |   |   |-- map_node_current.png
|   |   |   |-- map_node_daily.png
|   |   |   |-- map_node_event.png
|   |   |   |-- map_node_hard.png
|   |   |   |-- map_node_locked.png
|   |   |   |-- map_node_super_hard.png
|   |   |   |-- map_node_unplayed.png
|   |   |   +-- map_nodes_atlas.png
|   |   +-- Paths/
|   |       |-- map_path_bridge.png
|   |       |-- map_path_curve_left.png
|   |       |-- map_path_curve_right.png
|   |       |-- map_path_straight.png
|   |       |-- map_path_vertical.png
|   |       +-- map_paths_atlas.png
|   |-- Meta/
|   |   +-- BearVillage/
|   |       |-- Backgrounds/
|   |       |   +-- meta_bear_village_background.png
|   |       |-- Buildings/
|   |       |   |-- BeeGarden/
|   |       |   |   |-- meta_building_bee_garden_level_01.png
|   |       |   |   |-- meta_building_bee_garden_level_02.png
|   |       |   |   +-- meta_building_bee_garden_level_03.png
|   |       |   |-- BerryStand/
|   |       |   |   |-- meta_building_berry_stand_level_01.png
|   |       |   |   |-- meta_building_berry_stand_level_02.png
|   |       |   |   +-- meta_building_berry_stand_level_03.png
|   |       |   |-- HoneyHut/
|   |       |   |   |-- meta_building_honey_hut_level_01.png
|   |       |   |   |-- meta_building_honey_hut_level_02.png
|   |       |   |   +-- meta_building_honey_hut_level_03.png
|   |       |   |-- MushroomHouse/
|   |       |   |   |-- meta_building_mushroom_house_level_01.png
|   |       |   |   |-- meta_building_mushroom_house_level_02.png
|   |       |   |   +-- meta_building_mushroom_house_level_03.png
|   |       |   +-- PicnicArea/
|   |       |       |-- meta_building_picnic_area_level_01.png
|   |       |       |-- meta_building_picnic_area_level_02.png
|   |       |       +-- meta_building_picnic_area_level_03.png
|   |       +-- Plots/
|   |           |-- meta_empty_plot_large.png
|   |           |-- meta_empty_plot_medium.png
|   |           +-- meta_empty_plot_small.png
|   |-- Tiles/
|   |   |-- Blockers/
|   |   |   |-- blocker_ice_cracked.png
|   |   |   |-- blocker_ice_full.png
|   |   |   |-- blocker_pebble_cracked_01.png
|   |   |   |-- blocker_pebble_cracked_02.png
|   |   |   |-- blocker_pebble_full.png
|   |   |   |-- blocker_vine_cut_01.png
|   |   |   |-- blocker_vine_full.png
|   |   |   |-- covered_moss_tile.png
|   |   |   +-- moss_patch_tile.png
|   |   |-- Boosters/
|   |   |   |-- booster_hammer_icon.png
|   |   |   |-- booster_magic_glove_icon.png
|   |   |   |-- booster_paint_brush_icon.png
|   |   |   +-- shovel_booster_tile.png
|   |   |-- Core/
|   |   |   |-- acorn_tile.png
|   |   |   |-- bear_head_tile.png
|   |   |   |-- bee_tile.png
|   |   |   |-- blueberry_tile.png
|   |   |   |-- green_leaf_tile.png
|   |   |   |-- mushroom_tile.png
|   |   |   |-- pink_flower_tile.png
|   |   |   |-- red_berry_tile.png
|   |   |   +-- white_daisy_tile.png
|   |   |-- Objectives/
|   |   |   |-- basket_tile.png
|   |   |   |-- honey_pot_tile.png
|   |   |   |-- objective_acorn_nest_empty.png
|   |   |   |-- objective_acorn_nest_fill_01.png
|   |   |   |-- objective_acorn_nest_fill_02.png
|   |   |   |-- objective_acorn_nest_full.png
|   |   |   |-- objective_basket_empty.png
|   |   |   |-- objective_basket_fill_01.png
|   |   |   |-- objective_basket_fill_02.png
|   |   |   |-- objective_basket_full.png
|   |   |   |-- objective_honey_pot_cracked.png
|   |   |   |-- objective_honey_pot_empty.png
|   |   |   +-- objective_honey_pot_open.png
|   |   +-- Specials/
|   |       |-- berry_bomb_tile.png
|   |       |-- rainbow_blast_orb_tile.png
|   |       |-- rainbow_flower_tile.png
|   |       |-- special_rocket_base.png
|   |       |-- special_rocket_horizontal.png
|   |       |-- special_rocket_vertical.png
|   |       |-- striped_berry_rocket_tile.png
|   |       +-- super_berry_booster_tile.png
|   +-- UI/
|       |-- Buttons/
|       |   |-- ui_button_buy.png
|       |   |-- ui_button_challenge_friend.png
|       |   |-- ui_button_claim.png
|       |   |-- ui_button_close.png
|       |   |-- ui_button_continue.png
|       |   |-- ui_button_disabled.png
|       |   |-- ui_button_equip.png
|       |   |-- ui_button_play.png
|       |   |-- ui_button_primary.png
|       |   |-- ui_button_rematch.png
|       |   |-- ui_button_retry.png
|       |   +-- ui_button_secondary.png
|       |-- Challenge/
|       |   |-- avatar_frame_champion.png
|       |   |-- avatar_frame_common.png
|       |   |-- avatar_frame_event.png
|       |   |-- avatar_frame_rare.png
|       |   |-- challenge_draw_banner.png
|       |   |-- challenge_fair_mode_badge.png
|       |   |-- challenge_invite_panel.png
|       |   |-- challenge_leaderboard_panel.png
|       |   |-- challenge_lose_banner.png
|       |   |-- challenge_new_record_banner.png
|       |   |-- challenge_result_panel.png
|       |   |-- challenge_same_seed_badge.png
|       |   |-- challenge_timer_badge.png
|       |   |-- challenge_win_banner.png
|       |   |-- leaderboard_rank_badge_1.png
|       |   |-- leaderboard_rank_badge_2.png
|       |   |-- leaderboard_rank_badge_3.png
|       |   |-- leaderboard_row_friend.png
|       |   |-- leaderboard_row_normal.png
|       |   +-- leaderboard_row_self.png
|       |-- Event/
|       |-- HUD/
|       |   |-- bux_puzzle_logo.png
|       |   |-- goal_panel.png
|       |   |-- info_button.png
|       |   |-- level_panel.png
|       |   |-- menu_button.png
|       |   |-- moves_left_panel.png
|       |   |-- score_panel.png
|       |   |-- settings_button.png
|       |   +-- ui_booster_bar_panel.png
|       |-- Icons/
|       |   |-- Goals/
|       |   |   |-- goal_icon_acorn.png
|       |   |   |-- goal_icon_basket.png
|       |   |   |-- goal_icon_blueberry.png
|       |   |   |-- goal_icon_bomb.png
|       |   |   |-- goal_icon_covered_moss.png
|       |   |   |-- goal_icon_daisy.png
|       |   |   |-- goal_icon_flower.png
|       |   |   |-- goal_icon_honey_pot.png
|       |   |   |-- goal_icon_ice.png
|       |   |   |-- goal_icon_leaf.png
|       |   |   |-- goal_icon_moss.png
|       |   |   |-- goal_icon_mushroom.png
|       |   |   |-- goal_icon_pebble.png
|       |   |   |-- goal_icon_rainbow_orb.png
|       |   |   |-- goal_icon_red_berry.png
|       |   |   |-- goal_icon_rocket.png
|       |   |   +-- goal_icon_vine.png
|       |   |-- icon_booster_fragment.png
|       |   |-- icon_coin.png
|       |   |-- icon_cosmetic_shard.png
|       |   |-- icon_heart_life.png
|       |   |-- icon_honey_token.png
|       |   |-- icon_key.png
|       |   |-- icon_star.png
|       |   +-- icon_trophy.png
|       |-- Popups/
|       |   |-- ui_challenge_result_popup.png
|       |   |-- ui_chest_open_popup.png
|       |   |-- ui_daily_reward_popup.png
|       |   |-- ui_event_popup.png
|       |   |-- ui_friend_challenge_popup.png
|       |   |-- ui_level_complete_popup.png
|       |   |-- ui_level_failed_popup.png
|       |   |-- ui_level_start_popup.png
|       |   |-- ui_out_of_moves_popup.png
|       |   |-- ui_pause_popup.png
|       |   |-- ui_reward_popup.png
|       |   +-- ui_wardrobe_popup.png
|       |-- Rewards/
|       |   |-- chest_event_closed.png
|       |   |-- chest_event_open.png
|       |   |-- chest_friend_closed.png
|       |   |-- chest_friend_open.png
|       |   |-- chest_rare_closed.png
|       |   |-- chest_rare_open.png
|       |   |-- chest_small_closed.png
|       |   |-- chest_small_open.png
|       |   |-- chest_star_closed.png
|       |   +-- chest_star_open.png
|       +-- Tutorial/
|           |-- tutorial_hand_pointer.png
|           |-- tutorial_highlight_ring.png
|           |-- tutorial_speech_bubble.png
|           |-- tutorial_swipe_arrow_horizontal.png
|           |-- tutorial_swipe_arrow_vertical.png
|           +-- tutorial_tap_indicator.png
|-- Audio/
|   |-- Ambience/
|   |   |-- 01. Seamless Ambient Loop For A Cozy Magical Forest Mobile Match-3 Puzzle Gam.mp3
|   |   |-- 01_forest_day_ambience.mp3
|   |   |-- 02. Seamless Ambient Loop For A Cozy Magical Forest Mobile Match-3 Puzzle Gam.mp3
|   |   |-- 02_forest_evening_ambience.mp3
|   |   |-- 03. Seamless Ambient Loop For A Cozy Magical Forest Mobile Match-3 Puzzle Gam.mp3
|   |   |-- 03_magic_clearing_ambience.mp3
|   |   |-- 04. Seamless Ambient Loop For A Cozy Magical Forest Mobile Match-3 Puzzle Gam.mp3
|   |   |-- 04_honey_hills_ambience.mp3
|   |   |-- 05. Seamless Ambient Loop For A Cozy Magical Forest Mobile Match-3 Puzzle Gam.mp3
|   |   |-- 05_bear_village_ambience.mp3
|   |   |-- 34. Seamless Ambient Loop For A Cozy Magical Forest Mobile Match-3 Puzzle Gam.mp3
|   |   +-- 34_forest_ambience_duplicate.mp3
|   |-- Music/
|   |   |-- 06_main_menu_music.mp3
|   |   |-- 07_gameplay_calm_music.mp3
|   |   |-- 08_gameplay_challenge_music.mp3
|   |   |-- 09_low_moves_music.mp3
|   |   |-- 10_level_map_music.mp3
|   |   |-- 11_bear_village_music.mp3
|   |   |-- 12_wardrobe_music.mp3
|   |   |-- 13_friend_challenge_music.mp3
|   |   |-- 14_honey_harvest_music.mp3
|   |   |-- 31_main_menu_music_duplicate.mp3
|   |   |-- 32. Loopable Calm Gameplay Music For A Cozy Magical Forest Match-3 Puzzle Gam.mp3
|   |   |-- 32_gameplay_calm_music_duplicate.mp3
|   |   |-- 33. Loopable Level Map Music For A Cozy Magical Forest Match-3 Puzzle Game. A.mp3
|   |   +-- 33_level_map_music_duplicate.mp3
|   +-- SFX/
|       |-- Blockers/
|       |   |-- Covered Moss Crack. Create A Covered Moss Crack Sound, Soft Thick Vegetation.mp3
|       |   |-- Covered Moss Layer Removed. Create A Covered Moss Layer Removal Sound, Thick.mp3
|       |   |-- Ice Break. Create An Ice Blocker Break Sound, Delicate Ice Shards Cracking An.mp3
|       |   |-- Ice Hit. Create An Ice Blocker Hit Sound For A Cozy Puzzle Game, Light Crysta.mp3
|       |   |-- Pebble Break. Create A Pebble Blocker Break Sound, Small Stone Crack And Crum.mp3
|       |   |-- Pebble Hit. Create A Pebble Blocker Hit Sound, Small Rounded Stone Impact Wit.mp3
|       |   |-- Vine Cut. Create A Vine Blocker Cut Sound, Soft Plant Fiber Snap With Leafy R.mp3
|       |   +-- Vine Hit. Create A Vine Blocker Hit Sound, Soft Plant Fiber Tension With Leaf.mp3
|       |-- Board/
|       |   |-- Board Hint. Create A Soft Hint Sound For A Cozy Match-3 Puzzle Game, Gentle S.mp3
|       |   |-- Board Shuffle. Create A Board Shuffle Sound For A Cozy Forest Match-3 Game, M.mp3
|       |   |-- Invalid Tile Swap. Create A Friendly Invalid Move Sound For A Cozy Mobile Puz.mp3
|       |   |-- Tile Deselect. Create A Very Short Tile Deselect Sound For A Cozy Match-3 For.mp3
|       |   |-- Tile Falling. Create A Soft Tile Falling Sound For A Cozy Match-3 Puzzle Game.mp3
|       |   |-- Tile Landing. Create A Soft Tile Landing Sound For A Cozy Match-3 Game, Round.mp3
|       |   |-- Tile Return. Create A Short Tile Return Sound For An Invalid Match-3 Swap, So.mp3
|       |   |-- Tile Select. Create A Very Short Tile Selection Sound For A Cozy Match-3 Fore.mp3
|       |   |-- Tile Swap. Create A Short Tile Swap Sound For A Match-3 Mobile Game, Gentle S.mp3
|       |   +-- Valid Tile Swap. Create A Short Valid Tile Swap Sound For A Cozy Match-3 Game.mp3
|       |-- Boosters/
|       |-- Challenge/
|       |   |-- 24. Short Friend Challenge Sent Sound For A Cozy Magical Forest Puzzle Game.mp3
|       |   |-- 24_challenge_sent.mp3
|       |   |-- 25. Short Friend Challenge Received Notification For A Cozy Magical Forest Pu.mp3
|       |   |-- 25_challenge_received.mp3
|       |   |-- 26. Short Friend Challenge Win Stinger For A Cozy Magical Forest Puzzle Game.mp3
|       |   |-- 26_challenge_win.mp3
|       |   |-- 27. Short Friend Challenge Lose Stinger For A Cozy Magical Forest Puzzle Game.mp3
|       |   +-- 27_challenge_lose.mp3
|       |-- Companion/
|       |   |-- 28. Short Companion Bear Happy Reaction Sound For A Cozy Magical Forest Puzzl.mp3
|       |   |-- 28_bear_happy.mp3
|       |   |-- 29. Short Companion Bear Victory Reaction Sound For A Cozy Magical Forest Puz.mp3
|       |   |-- 29_bear_victory.mp3
|       |   |-- 30. Short Companion Bear Worried Reaction Sound For A Cozy Magical Forest Puz.mp3
|       |   |-- 30_bear_worried.mp3
|       |   |-- Bear Paw Impact. Create A Short Bear Paw Impact Sound, Soft Padded Impact Wit.mp3
|       |   |-- Bear Paw Swipe. Create A Bear Paw Swipe Sound For A Cozy Match-3 Game, Soft F.mp3
|       |   |-- Bear Tile Match. Create A Short Bear Helper Tile Match Sound For A Cozy Fores.mp3
|       |   |-- Bee Fly To Target. Create A Short Bee Flying Helper Sound, Gentle Tiny Wing B.mp3
|       |   |-- Bee Pollinate. Create A Short Bee Pollination Sound, Soft Pollen Sparkle Burs.mp3
|       |   +-- Bee Tile Match. Create A Short Bee Tile Match Sound, Tiny Friendly Bee Buzz W.mp3
|       |-- Meta/
|       |-- Notifications/
|       |-- Objectives/
|       |   |-- 18. Short Objective Complete Stinger For A Cozy Magical Forest Match-3 Game.mp3
|       |   |-- 18_objective_complete.mp3
|       |   |-- Acorn Nest Complete. Create An Acorn Nest Objective Complete Sound, Warm Natu.mp3
|       |   |-- Acorn Nest Fill. Create An Acorn Nest Fill Sound, Small Acorns Dropping Into.mp3
|       |   |-- Basket Collect. Create A Basket Collect Sound For A Cozy Match-3 Game, Small.mp3
|       |   |-- Basket Complete. Create A Basket Objective Complete Sound, Warm Little Chime.mp3
|       |   |-- Basket Fill. Create A Basket Fill Sound, Several Tiny Fruit Pieces Settling I.mp3
|       |   |-- Bee Honey Hit. Create A Short Bee Honey Hit Sound, Tiny Friendly Buzz Landing.mp3
|       |   |-- Honey Collect. Create A Honey Collect Sound, Warm Sticky Honey Swirl With Sof.mp3
|       |   |-- Honey Pot Hit. Create A Honey Pot Hit Sound, Soft Ceramic Tap With Sticky Hon.mp3
|       |   +-- Honey Pot Open. Create A Honey Pot Opening Sound, Small Ceramic Lid Pop With.mp3
|       |-- Rewards/
|       |   |-- 17. Short Level Start Stinger For A Cozy Magical Forest Match-3 Game. Light M.mp3
|       |   |-- 17_level_start.mp3
|       |   |-- 22. Short Coin Collect Sound For A Cozy Magical Forest Mobile Puzzle Game. So.mp3
|       |   |-- 22_coin_collect.mp3
|       |   |-- 23. Short Star Appear Sound For A Cozy Magical Forest Puzzle Game. Gentle Mag.mp3
|       |   |-- 23_star_appear.mp3
|       |   +-- Rare Chest Open. Create A Rare Reward Chest Opening Sound, Richer Wooden Ches.mp3
|       |-- Specials/
|       |   |-- 20. Short Special Tile Created Sound For A Match-4 In A Cozy Magical Forest P.mp3
|       |   |-- 20_match_4_special_created.mp3
|       |   |-- 21. Short Rare Special Tile Created Sound For A Match-5 In A Cozy Magical For.mp3
|       |   |-- 21_match_5_special_created.mp3
|       |   |-- Berry Bomb Charge. Create A Berry Bomb Charge Sound For A Cozy Match-3 Game,.mp3
|       |   |-- Berry Bomb Explosion. Create A Berry Bomb Explosion Sound, Juicy Fruit Burst.mp3
|       |   |-- Rainbow Flower Bloom. Create A Rainbow Flower Activation Sound, Large Magical.mp3
|       |   |-- Rainbow Flower Cleanse Hit. Create A Rainbow Flower Cleanse Hit Sound, Warm M.mp3
|       |   |-- Rainbow Orb Charge. Create A Rainbow Orb Charge Sound, Premium Magical Rising.mp3
|       |   |-- Rainbow Orb Clear. Create A Rainbow Full Color Clear Sound For A Cozy Match-3.mp3
|       |   |-- Rocket Charge. Create A Striped Berry Rocket Charge Sound, Playful Tiny Rocke.mp3
|       |   |-- Rocket Fire Horizontal. Create A Horizontal Rocket Fire Sound For A Cozy Matc.mp3
|       |   |-- Rocket Fire Vertical. Create A Vertical Rocket Fire Sound For A Cozy Match-3.mp3
|       |   |-- Super Berry Activate. Create A Super Berry Activation Sound, Powerful Juicy B.mp3
|       |   +-- Super Berry Cross Beam. Create A Super Berry Cross Beam Sound, Bright Juicy E.mp3
|       |-- Tiles/
|       |   |-- Acorn Collect. Create A Short Acorn Collect Sound, Small Acorn Dropping Into.mp3
|       |   |-- Acorn Match. Create A Short Acorn Match Sound, Small Wooden Nut Crack And Sof.mp3
|       |   |-- Blueberry Cascade Bonus. Create A Short Blueberry Cascade Bonus Sound, Bouncy.mp3
|       |   |-- Blueberry Match. Create A Short Blueberry Match Sound, Round Bouncy Berry Pop.mp3
|       |   |-- Green Leaf Match. Create A Short Green Leaf Match Sound For A Cozy Magical Fo.mp3
|       |   |-- Green Leaf Wind Swirl. Create A Short Leaf Wind Swirl Sound, Gentle Spinning.mp3
|       |   |-- Mushroom Match. Create A Short Mushroom Match Sound For A Cozy Forest Puzzle.mp3
|       |   |-- Mushroom Spore Puff. Create A Short Mushroom Spore Puff Sound, Soft Airy Puff.mp3
|       |   |-- Pink Flower Cleanse. Create A Short Flower Cleanse Sound, Soft Pollen Sparkle.mp3
|       |   |-- Pink Flower Match. Create A Short Pink Flower Match Sound, Soft Bloom Opening.mp3
|       |   |-- Red Berry Collect. Create A Short Red Berry Collect Sound For A Cozy Puzzle G.mp3
|       |   |-- Red Berry Match. Create A Short Red Berry Match Sound For A Cozy Match-3 Game.mp3
|       |   |-- White Daisy Cleanse. Create A Short White Daisy Cleanse Sound, Pure Soft Chim.mp3
|       |   +-- White Daisy Match. Create A Short White Daisy Match Sound, Clean Gentle Spark.mp3
|       |-- Tutorial/
|       +-- UI/
|           |-- 15_level_win.mp3
|           |-- 16. Short Gentle Level Failed Stinger For A Cozy Magical Forest Match-3 Game.mp3
|           |-- 16_level_failed.mp3
|           |-- 19. Short Low Moves Warning Sound For A Cozy Magical Forest Match-3 Game. Gen.mp3
|           |-- 19_low_moves_warning.mp3
|           |-- Button Tap. Create A Very Short Mobile Game Ui Button Tap Sound, Cozy Magical.mp3
|           |-- Cancel. Create A Short Cancel Sound For A Cozy Forest Puzzle Game, Soft Downw.mp3
|           |-- Confirmation. Create A Short Positive Confirmation Sound For A Cozy Mobile Pu.mp3
|           |-- Disabled Button. Create A Short Disabled Button Sound For A Cozy Forest Puzzl.mp3
|           |-- Popup Close. Create A Short Popup Close Sound, Soft Reverse Whoosh With Tiny.mp3
|           +-- Popup Open. Create A Short Popup Opening Sound For A Cozy Magical Forest Mobi.mp3
+-- Data/
    +-- Manifests/
        |-- Reports/
        |   |-- asset_audit.md
        |   |-- board_and_map_asset_filenames.txt
        |   |-- BUX_Puzzle_Project_Package_Analysis_and_Structure_Addendum.md
        |   |-- elevenlabs_mobile_game_sfx_prompts_no_music.csv
        |   |-- game_asset_filenames.txt
        |   |-- game_asset_prompts.csv
        |   |-- game_assets_01_to_17_with_prompts.csv
        |   |-- last_batch_asset_filenames.txt
        |   |-- numbered_asset_names_objectives_specials_goals (1).docx
        |   |-- suno_sound_mapping_report.md
        |   |-- suno_sound_names_numbered.docx
        |   |-- tree.txt
        |   |-- tree__conflict_1.txt
        |   |-- unsorted3_mapping_report.md
        |   +-- unsorted4_mapping_report.md
        |-- asset_manifest.csv
        |-- audio_manifest.csv
        |-- duplicates_report.md
        |-- import_summary.md
        +-- missing_assets_report.md
```
