﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Building_Generator.Constants
{

    /**
     * NEED TO DESERIALIZE THE JSON OF BLOCK DATA INTO A LIST of block classes so that they can be used easily.
     * 
     * This task will be on hold for a while.
     */




    public class Blocks
    {
        public static Dictionary<int, Block> blockList = new Dictionary<int, Block>();    



        public void Populate_BlockList()
        {


            //Block account = JsonConvert.DeserializeObject<Block>(block_data_JSON);
            //List<Block> Blocks = JsonConvert.DeserializeObject<List<Block>>(block_data_JSON);

            var objects = JsonConvert.DeserializeObject<List<Block>>(block_data_JSON);
            var result = objects.Select(obj => JsonConvert.SerializeObject(obj)).ToArray();


        }


        public string block_data_JSON =
                @"[
           {
              'id': 0,
              'datavalue': 0,
              'name': 'Air',
              'type': 'air'
           },
           {
              'id': 1,
              'datavalue': 0,
              'name': 'Stone',
              'type': 'stone'
           },
           {
              'id': 1,
              'datavalue': 1,
              'name': 'Granite',
              'type': 'stone'
           },
           {
              'id': 1,
              'datavalue': 2,
              'name': 'Polished Granite',
              'type': 'stone'
           },
           {
              'id': 1,
              'datavalue': 3,
              'name': 'Diorite',
              'type': 'stone'
           },
           {
              'id': 1,
              'datavalue': 4,
              'name': 'Polished Diorite',
              'type': 'stone'
           },
           {
              'id': 1,
              'datavalue': 5,
              'name': 'Andesite',
              'type': 'stone'
           },
           {
              'id': 1,
              'datavalue': 6,
              'name': 'Polished Andesite',
              'type': 'stone'
           },
           {
              'id': 2,
              'datavalue': 0,
              'name': 'Grass',
              'type': 'grass'
           },
           {
              'id': 3,
              'datavalue': 0,
              'name': 'Dirt',
              'type': 'dirt'
           },
           {
              'id': 3,
              'datavalue': 1,
              'name': 'Coarse Dirt',
              'type': 'dirt'
           },
           {
              'id': 3,
              'datavalue': 2,
              'name': 'Podzol',
              'type': 'dirt'
           },
           {
              'id': 4,
              'datavalue': 0,
              'name': 'Cobblestone',
              'type': 'cobblestone'
           },
           {
              'id': 5,
              'datavalue': 0,
              'name': 'Oak Wood Plank',
              'type': 'planks'
           },
           {
              'id': 5,
              'datavalue': 1,
              'name': 'Spruce Wood Plank',
              'type': 'planks'
           },
           {
              'id': 5,
              'datavalue': 2,
              'name': 'Birch Wood Plank',
              'type': 'planks'
           },
           {
              'id': 5,
              'datavalue': 3,
              'name': 'Jungle Wood Plank',
              'type': 'planks'
           },
           {
              'id': 5,
              'datavalue': 4,
              'name': 'Acacia Wood Plank',
              'type': 'planks'
           },
           {
              'id': 5,
              'datavalue': 5,
              'name': 'Dark Oak Wood Plank',
              'type': 'planks'
           },
           {
              'id': 6,
              'datavalue': 0,
              'name': 'Oak Sapling',
              'type': 'sapling'
           },
           {
              'id': 6,
              'datavalue': 1,
              'name': 'Spruce Sapling',
              'type': 'sapling'
           },
           {
              'id': 6,
              'datavalue': 2,
              'name': 'Birch Sapling',
              'type': 'sapling'
           },
           {
              'id': 6,
              'datavalue': 3,
              'name': 'Jungle Sapling',
              'type': 'sapling'
           },
           {
              'id': 6,
              'datavalue': 4,
              'name': 'Acacia Sapling',
              'type': 'sapling'
           },
           {
              'id': 6,
              'datavalue': 5,
              'name': 'Dark Oak Sapling',
              'type': 'sapling'
           },
           {
              'id': 7,
              'datavalue': 0,
              'name': 'Bedrock',
              'type': 'bedrock'
           },
           {
              'id': 8,
              'datavalue': 0,
              'name': 'Flowing Water',
              'type': 'flowing_water'
           },
           {
              'id': 9,
              'datavalue': 0,
              'name': 'Still Water',
              'type': 'water'
           },
           {
              'id': 10,
              'datavalue': 0,
              'name': 'Flowing Lava',
              'type': 'flowing_lava'
           },
           {
              'id': 11,
              'datavalue': 0,
              'name': 'Still Lava',
              'type': 'lava'
           },
           {
              'id': 12,
              'datavalue': 0,
              'name': 'Sand',
              'type': 'sand'
           },
           {
              'id': 12,
              'datavalue': 1,
              'name': 'Red Sand',
              'type': 'sand'
           },
           {
              'id': 13,
              'datavalue': 0,
              'name': 'Gravel',
              'type': 'gravel'
           },
           {
              'id': 14,
              'datavalue': 0,
              'name': 'Gold Ore',
              'type': 'gold_ore'
           },
           {
              'id': 15,
              'datavalue': 0,
              'name': 'Iron Ore',
              'type': 'iron_ore'
           },
           {
              'id': 16,
              'datavalue': 0,
              'name': 'Coal Ore',
              'type': 'coal_ore'
           },
           {
              'id': 17,
              'datavalue': 0,
              'name': 'Oak Wood',
              'type': 'log'
           },
           {
              'id': 17,
              'datavalue': 1,
              'name': 'Spruce Wood',
              'type': 'log'
           },
           {
              'id': 17,
              'datavalue': 2,
              'name': 'Birch Wood',
              'type': 'log'
           },
           {
              'id': 17,
              'datavalue': 3,
              'name': 'Jungle Wood',
              'type': 'log'
           },
           {
              'id': 18,
              'datavalue': 0,
              'name': 'Oak Leaves',
              'type': 'leaves'
           },
           {
              'id': 18,
              'datavalue': 1,
              'name': 'Spruce Leaves',
              'type': 'leaves'
           },
           {
              'id': 18,
              'datavalue': 2,
              'name': 'Birch Leaves',
              'type': 'leaves'
           },
           {
              'id': 18,
              'datavalue': 3,
              'name': 'Jungle Leaves',
              'type': 'leaves'
           },
           {
              'id': 19,
              'datavalue': 0,
              'name': 'Sponge',
              'type': 'sponge'
           },
           {
              'id': 19,
              'datavalue': 1,
              'name': 'Wet Sponge',
              'type': 'sponge'
           },
           {
              'id': 20,
              'datavalue': 0,
              'name': 'Glass',
              'type': 'glass'
           },
           {
              'id': 21,
              'datavalue': 0,
              'name': 'Lapis Lazuli Ore',
              'type': 'lapis_ore'
           },
           {
              'id': 22,
              'datavalue': 0,
              'name': 'Lapis Lazuli Block',
              'type': 'lapis_block'
           },
           {
              'id': 23,
              'datavalue': 0,
              'name': 'Dispenser',
              'type': 'dispenser'
           },
           {
              'id': 24,
              'datavalue': 0,
              'name': 'Sandstone',
              'type': 'sandstone'
           },
           {
              'id': 24,
              'datavalue': 1,
              'name': 'Chiseled Sandstone',
              'type': 'sandstone'
           },
           {
              'id': 24,
              'datavalue': 2,
              'name': 'Smooth Sandstone',
              'type': 'sandstone'
           },
           {
              'id': 25,
              'datavalue': 0,
              'name': 'Note Block',
              'type': 'noteblock'
           },
           {
              'id': 26,
              'datavalue': 0,
              'name': 'Bed',
              'type': 'bed'
           },
           {
              'id': 27,
              'datavalue': 0,
              'name': 'Powered Rail',
              'type': 'golden_rail'
           },
           {
              'id': 28,
              'datavalue': 0,
              'name': 'Detector Rail',
              'type': 'detector_rail'
           },
           {
              'id': 29,
              'datavalue': 0,
              'name': 'Sticky Piston',
              'type': 'sticky_piston'
           },
           {
              'id': 30,
              'datavalue': 0,
              'name': 'Cobweb',
              'type': 'web'
           },
           {
              'id': 31,
              'datavalue': 0,
              'name': 'Dead Shrub',
              'type': 'tallgrass'
           },
           {
              'id': 31,
              'datavalue': 1,
              'name': 'Grass',
              'type': 'tallgrass'
           },
           {
              'id': 31,
              'datavalue': 2,
              'name': 'Fern',
              'type': 'tallgrass'
           },
           {
              'id': 32,
              'datavalue': 0,
              'name': 'Dead Bush',
              'type': 'deadbush'
           },
           {
              'id': 33,
              'datavalue': 0,
              'name': 'Piston',
              'type': 'piston'
           },
           {
              'id': 34,
              'datavalue': 0,
              'name': 'Piston Head',
              'type': 'piston_head'
           },
           {
              'id': 35,
              'datavalue': 0,
              'name': 'White Wool',
              'type': 'wool'
           },
           {
              'id': 35,
              'datavalue': 1,
              'name': 'Orange Wool',
              'type': 'wool'
           },
           {
              'id': 35,
              'datavalue': 2,
              'name': 'Magenta Wool',
              'type': 'wool'
           },
           {
              'id': 35,
              'datavalue': 3,
              'name': 'Light 
Wool',
              'type': 'wool'
           },
           {
              'id': 35,
              'datavalue': 4,
              'name': 'Yellow Wool',
              'type': 'wool'
           },
           {
              'id': 35,
              'datavalue': 5,
              'name': 'Lime Wool',
              'type': 'wool'
           },
           {
              'id': 35,
              'datavalue': 6,
              'name': 'Pink Wool',
              'type': 'wool'
           },
           {
              'id': 35,
              'datavalue': 7,
              'name': 'Gray Wool',
              'type': 'wool'
           },
           {
              'id': 35,
              'datavalue': 8,
              'name': 'Light Gray Wool',
              'type': 'wool'
           },
           {
              'id': 35,
              'datavalue': 9,
              'name': 'Cyan Wool',
              'type': 'wool'
           },
           {
              'id': 35,
              'datavalue': 10,
              'name': 'Purple Wool',
              'type': 'wool'
           },
           {
              'id': 35,
              'datavalue': 11,
              'name': 'Blue Wool',
              'type': 'wool'
           },
           {
              'id': 35,
              'datavalue': 12,
              'name': 'Brown Wool',
              'type': 'wool'
           },
           {
              'id': 35,
              'datavalue': 13,
              'name': 'Green Wool',
              'type': 'wool'
           },
           {
              'id': 35,
              'datavalue': 14,
              'name': 'Red Wool',
              'type': 'wool'
           },
           {
              'id': 35,
              'datavalue': 15,
              'name': 'Black Wool',
              'type': 'wool'
           },
           {
              'id': 37,
              'datavalue': 0,
              'name': 'Dandelion',
              'type': 'yellow_flower'
           },
           {
              'id': 38,
              'datavalue': 0,
              'name': 'Poppy',
              'type': 'red_flower'
           },
           {
              'id': 38,
              'datavalue': 1,
              'name': 'Blue Orchid',
              'type': 'red_flower'
           },
           {
              'id': 38,
              'datavalue': 2,
              'name': 'Allium',
              'type': 'red_flower'
           },
           {
              'id': 38,
              'datavalue': 3,
              'name': 'Azure Bluet',
              'type': 'red_flower'
           },
           {
              'id': 38,
              'datavalue': 4,
              'name': 'Red Tulip',
              'type': 'red_flower'
           },
           {
              'id': 38,
              'datavalue': 5,
              'name': 'Orange Tulip',
              'type': 'red_flower'
           },
           {
              'id': 38,
              'datavalue': 6,
              'name': 'White Tulip',
              'type': 'red_flower'
           },
           {
              'id': 38,
              'datavalue': 7,
              'name': 'Pink Tulip',
              'type': 'red_flower'
           },
           {
              'id': 38,
              'datavalue': 8,
              'name': 'Oxeye Daisy',
              'type': 'red_flower'
           },
           {
              'id': 39,
              'datavalue': 0,
              'name': 'Brown Mushroom',
              'type': 'brown_mushroom'
           },
           {
              'id': 40,
              'datavalue': 0,
              'name': 'Red Mushroom',
              'type': 'red_mushroom'
           },
           {
              'id': 41,
              'datavalue': 0,
              'name': 'Gold Block',
              'type': 'gold_block'
           },
           {
              'id': 42,
              'datavalue': 0,
              'name': 'Iron Block',
              'type': 'iron_block'
           },
           {
              'id': 43,
              'datavalue': 0,
              'name': 'Double Stone Slab',
              'type': 'double_stone_slab'
           },
           {
              'id': 43,
              'datavalue': 1,
              'name': 'Double Sandstone Slab',
              'type': 'double_stone_slab'
           },
           {
              'id': 43,
              'datavalue': 2,
              'name': 'Double Wooden Slab',
              'type': 'double_stone_slab'
           },
           {
              'id': 43,
              'datavalue': 3,
              'name': 'Double Cobblestone Slab',
              'type': 'double_stone_slab'
           },
           {
              'id': 43,
              'datavalue': 4,
              'name': 'Double Brick Slab',
              'type': 'double_stone_slab'
           },
           {
              'id': 43,
              'datavalue': 5,
              'name': 'Double Stone Brick Slab',
              'type': 'double_stone_slab'
           },
           {
              'id': 43,
              'datavalue': 6,
              'name': 'Double Nether Brick Slab',
              'type': 'double_stone_slab'
           },
           {
              'id': 43,
              'datavalue': 7,
              'name': 'Double Quartz Slab',
              'type': 'double_stone_slab'
           },
           {
              'id': 44,
              'datavalue': 0,
              'name': 'Stone Slab',
              'type': 'stone_slab'
           },
           {
              'id': 44,
              'datavalue': 1,
              'name': 'Sandstone Slab',
              'type': 'stone_slab'
           },
           {
              'id': 44,
              'datavalue': 2,
              'name': 'Wooden Slab',
              'type': 'stone_slab'
           },
           {
              'id': 44,
              'datavalue': 3,
              'name': 'Cobblestone Slab',
              'type': 'stone_slab'
           },
           {
              'id': 44,
              'datavalue': 4,
              'name': 'Brick Slab',
              'type': 'stone_slab'
           },
           {
              'id': 44,
              'datavalue': 5,
              'name': 'Stone Brick Slab',
              'type': 'stone_slab'
           },
           {
              'id': 44,
              'datavalue': 6,
              'name': 'Nether Brick Slab',
              'type': 'stone_slab'
           },
           {
              'id': 44,
              'datavalue': 7,
              'name': 'Quartz Slab',
              'type': 'stone_slab'
           },
           {
              'id': 45,
              'datavalue': 0,
              'name': 'Bricks',
              'type': 'brick_block'
           },
           {
              'id': 46,
              'datavalue': 0,
              'name': 'TNT',
              'type': 'tnt'
           },
           {
              'id': 47,
              'datavalue': 0,
              'name': 'Bookshelf',
              'type': 'bookshelf'
           },
           {
              'id': 48,
              'datavalue': 0,
              'name': 'Moss Stone',
              'type': 'mossy_cobblestone'
           },
           {
              'id': 49,
              'datavalue': 0,
              'name': 'Obsidian',
              'type': 'obsidian'
           },
           {
              'id': 50,
              'datavalue': 0,
              'name': 'Torch',
              'type': 'torch'
           },
           {
              'id': 51,
              'datavalue': 0,
              'name': 'Fire',
              'type': 'fire'
           },
           {
              'id': 52,
              'datavalue': 0,
              'name': 'Monster Spawner',
              'type': 'mob_spawner'
           },
           {
              'id': 53,
              'datavalue': 0,
              'name': 'Oak Wood Stairs',
              'type': 'oak_stairs'
           },
           {
              'id': 54,
              'datavalue': 0,
              'name': 'Chest',
              'type': 'chest'
           },
           {
              'id': 55,
              'datavalue': 0,
              'name': 'Redstone Wire',
              'type': 'redstone_wire'
           },
           {
              'id': 56,
              'datavalue': 0,
              'name': 'Diamond Ore',
              'type': 'diamond_ore'
           },
           {
              'id': 57,
              'datavalue': 0,
              'name': 'Diamond Block',
              'type': 'diamond_block'
           },
           {
              'id': 58,
              'datavalue': 0,
              'name': 'Crafting Table',
              'type': 'crafting_table'
           },
           {
              'id': 59,
              'datavalue': 0,
              'name': 'Wheat Crops',
              'type': 'wheat'
           },
           {
              'id': 60,
              'datavalue': 0,
              'name': 'Farmland',
              'type': 'farmland'
           },
           {
              'id': 61,
              'datavalue': 0,
              'name': 'Furnace',
              'type': 'furnace'
           },
           {
              'id': 62,
              'datavalue': 0,
              'name': 'Burning Furnace',
              'type': 'lit_furnace'
           },
           {
              'id': 63,
              'datavalue': 0,
              'name': 'Standing Sign Block',
              'type': 'standing_sign'
           },
           {
              'id': 64,
              'datavalue': 0,
              'name': 'Oak Door Block',
              'type': 'wooden_door'
           },
           {
              'id': 65,
              'datavalue': 0,
              'name': 'Ladder',
              'type': 'ladder'
           },
           {
              'id': 66,
              'datavalue': 0,
              'name': 'Rail',
              'type': 'rail'
           },
           {
              'id': 67,
              'datavalue': 0,
              'name': 'Cobblestone Stairs',
              'type': 'stone_stairs'
           },
           {
              'id': 68,
              'datavalue': 0,
              'name': 'Wall-mounted Sign Block',
              'type': 'wall_sign'
           },
           {
              'id': 69,
              'datavalue': 0,
              'name': 'Lever',
              'type': 'lever'
           },
           {
              'id': 70,
              'datavalue': 0,
              'name': 'Stone Pressure Plate',
              'type': 'stone_pressure_plate'
           },
           {
              'id': 71,
              'datavalue': 0,
              'name': 'Iron Door Block',
              'type': 'iron_door'
           },
           {
              'id': 72,
              'datavalue': 0,
              'name': 'Wooden Pressure Plate',
              'type': 'wooden_pressure_plate'
           },
           {
              'id': 73,
              'datavalue': 0,
              'name': 'Redstone Ore',
              'type': 'redstone_ore'
           },
           {
              'id': 74,
              'datavalue': 0,
              'name': 'Glowing Redstone Ore',
              'type': 'lit_redstone_ore'
           },
           {
              'id': 75,
              'datavalue': 0,
              'name': 'Redstone Torch (off)',
              'type': 'unlit_redstone_torch'
           },
           {
              'id': 76,
              'datavalue': 0,
              'name': 'Redstone Torch (on)',
              'type': 'redstone_torch'
           },
           {
              'id': 77,
              'datavalue': 0,
              'name': 'Stone Button',
              'type': 'stone_button'
           },
           {
              'id': 78,
              'datavalue': 0,
              'name': 'Snow',
              'type': 'snow_layer'
           },
           {
              'id': 79,
              'datavalue': 0,
              'name': 'Ice',
              'type': 'ice'
           },
           {
              'id': 80,
              'datavalue': 0,
              'name': 'Snow Block',
              'type': 'snow'
           },
           {
              'id': 81,
              'datavalue': 0,
              'name': 'Cactus',
              'type': 'cactus'
           },
           {
              'id': 82,
              'datavalue': 0,
              'name': 'Clay',
              'type': 'clay'
           },
           {
              'id': 83,
              'datavalue': 0,
              'name': 'Sugar Canes',
              'type': 'reeds'
           },
           {
              'id': 84,
              'datavalue': 0,
              'name': 'Jukebox',
              'type': 'jukebox'
           },
           {
              'id': 85,
              'datavalue': 0,
              'name': 'Oak Fence',
              'type': 'fence'
           },
           {
              'id': 86,
              'datavalue': 0,
              'name': 'Pumpkin',
              'type': 'pumpkin'
           },
           {
              'id': 87,
              'datavalue': 0,
              'name': 'Netherrack',
              'type': 'netherrack'
           },
           {
              'id': 88,
              'datavalue': 0,
              'name': 'Soul Sand',
              'type': 'soul_sand'
           },
           {
              'id': 89,
              'datavalue': 0,
              'name': 'Glowstone',
              'type': 'glowstone'
           },
           {
              'id': 90,
              'datavalue': 0,
              'name': 'Nether Portal',
              'type': 'portal'
           },
           {
              'id': 91,
              'datavalue': 0,
              'name': 'Jack o'Lantern',
              'type': 'lit_pumpkin'
           },
           {
              'id': 92,
              'datavalue': 0,
              'name': 'Cake Block',
              'type': 'cake'
           },
           {
              'id': 93,
              'datavalue': 0,
              'name': 'Redstone Repeater Block (off)',
              'type': 'unpowered_repeater'
           },
           {
              'id': 94,
              'datavalue': 0,
              'name': 'Redstone Repeater Block (on)',
              'type': 'powered_repeater'
           },
           {
              'id': 95,
              'datavalue': 0,
              'name': 'White Stained Glass',
              'type': 'stained_glass'
           },
           {
              'id': 95,
              'datavalue': 1,
              'name': 'Orange Stained Glass',
              'type': 'stained_glass'
           },
           {
              'id': 95,
              'datavalue': 2,
              'name': 'Magenta Stained Glass',
              'type': 'stained_glass'
           },
           {
              'id': 95,
              'datavalue': 3,
              'name': 'Light Blue Stained Glass',
              'type': 'stained_glass'
           },
           {
              'id': 95,
              'datavalue': 4,
              'name': 'Yellow Stained Glass',
              'type': 'stained_glass'
           },
           {
              'id': 95,
              'datavalue': 5,
              'name': 'Lime Stained Glass',
              'type': 'stained_glass'
           },
           {
              'id': 95,
              'datavalue': 6,
              'name': 'Pink Stained Glass',
              'type': 'stained_glass'
           },
           {
              'id': 95,
              'datavalue': 7,
              'name': 'Gray Stained Glass',
              'type': 'stained_glass'
           },
           {
              'id': 95,
              'datavalue': 8,
              'name': 'Light Gray Stained Glass',
              'type': 'stained_glass'
           },
           {
              'id': 95,
              'datavalue': 9,
              'name': 'Cyan Stained Glass',
              'type': 'stained_glass'
           },
           {
              'id': 95,
              'datavalue': 10,
              'name': 'Purple Stained Glass',
              'type': 'stained_glass'
           },
           {
              'id': 95,
              'datavalue': 11,
              'name': 'Blue Stained Glass',
              'type': 'stained_glass'
           },
           {
              'id': 95,
              'datavalue': 12,
              'name': 'Brown Stained Glass',
              'type': 'stained_glass'
           },
           {
              'id': 95,
              'datavalue': 13,
              'name': 'Green Stained Glass',
              'type': 'stained_glass'
           },
           {
              'id': 95,
              'datavalue': 14,
              'name': 'Red Stained Glass',
              'type': 'stained_glass'
           },
           {
              'id': 95,
              'datavalue': 15,
              'name': 'Black Stained Glass',
              'type': 'stained_glass'
           },
           {
              'id': 96,
              'datavalue': 0,
              'name': 'Wooden Trapdoor',
              'type': 'trapdoor'
           },
           {
              'id': 97,
              'datavalue': 0,
              'name': 'Stone Monster Egg',
              'type': 'monster_egg'
           },
           {
              'id': 97,
              'datavalue': 1,
              'name': 'Cobblestone Monster Egg',
              'type': 'monster_egg'
           },
           {
              'id': 97,
              'datavalue': 2,
              'name': 'Stone Brick Monster Egg',
              'type': 'monster_egg'
           },
           {
              'id': 97,
              'datavalue': 3,
              'name': 'Mossy Stone Brick Monster Egg',
              'type': 'monster_egg'
           },
           {
              'id': 97,
              'datavalue': 4,
              'name': 'Cracked Stone Brick Monster Egg',
              'type': 'monster_egg'
           },
           {
              'id': 97,
              'datavalue': 5,
              'name': 'Chiseled Stone Brick Monster Egg',
              'type': 'monster_egg'
           },
           {
              'id': 98,
              'datavalue': 0,
              'name': 'Stone Bricks',
              'type': 'stonebrick'
           },
           {
              'id': 98,
              'datavalue': 1,
              'name': 'Mossy Stone Bricks',
              'type': 'stonebrick'
           },
           {
              'id': 98,
              'datavalue': 2,
              'name': 'Cracked Stone Bricks',
              'type': 'stonebrick'
           },
           {
              'id': 98,
              'datavalue': 3,
              'name': 'Chiseled Stone Bricks',
              'type': 'stonebrick'
           },
           {
              'id': 99,
              'datavalue': 0,
              'name': 'Brown Mushroom Block',
              'type': 'brown_mushroom_block'
           },
           {
              'id': 100,
              'datavalue': 0,
              'name': 'Red Mushroom Block',
              'type': 'red_mushroom_block'
           },
           {
              'id': 101,
              'datavalue': 0,
              'name': 'Iron Bars',
              'type': 'iron_bars'
           },
           {
              'id': 102,
              'datavalue': 0,
              'name': 'Glass Pane',
              'type': 'glass_pane'
           },
           {
              'id': 103,
              'datavalue': 0,
              'name': 'Melon Block',
              'type': 'melon_block'
           },
           {
              'id': 104,
              'datavalue': 0,
              'name': 'Pumpkin Stem',
              'type': 'pumpkin_stem'
           },
           {
              'id': 105,
              'datavalue': 0,
              'name': 'Melon Stem',
              'type': 'melon_stem'
           },
           {
              'id': 106,
              'datavalue': 0,
              'name': 'Vines',
              'type': 'vine'
           },
           {
              'id': 107,
              'datavalue': 0,
              'name': 'Oak Fence Gate',
              'type': 'fence_gate'
           },
           {
              'id': 108,
              'datavalue': 0,
              'name': 'Brick Stairs',
              'type': 'brick_stairs'
           },
           {
              'id': 109,
              'datavalue': 0,
              'name': 'Stone Brick Stairs',
              'type': 'stone_brick_stairs'
           },
           {
              'id': 110,
              'datavalue': 0,
              'name': 'Mycelium',
              'type': 'mycelium'
           },
           {
              'id': 111,
              'datavalue': 0,
              'name': 'Lily Pad',
              'type': 'waterlily'
           },
           {
              'id': 112,
              'datavalue': 0,
              'name': 'Nether Brick',
              'type': 'nether_brick'
           },
           {
              'id': 113,
              'datavalue': 0,
              'name': 'Nether Brick Fence',
              'type': 'nether_brick_fence'
           },
           {
              'id': 114,
              'datavalue': 0,
              'name': 'Nether Brick Stairs',
              'type': 'nether_brick_stairs'
           },
           {
              'id': 115,
              'datavalue': 0,
              'name': 'Nether Wart',
              'type': 'nether_wart'
           },
           {
              'id': 116,
              'datavalue': 0,
              'name': 'Enchantment Table',
              'type': 'enchanting_table'
           },
           {
              'id': 117,
              'datavalue': 0,
              'name': 'Brewing Stand',
              'type': 'brewing_stand'
           },
           {
              'id': 118,
              'datavalue': 0,
              'name': 'Cauldron',
              'type': 'cauldron'
           },
           {
              'id': 119,
              'datavalue': 0,
              'name': 'End Portal',
              'type': 'end_portal'
           },
           {
              'id': 120,
              'datavalue': 0,
              'name': 'End Portal Frame',
              'type': 'end_portal_frame'
           },
           {
              'id': 121,
              'datavalue': 0,
              'name': 'End Stone',
              'type': 'end_stone'
           },
           {
              'id': 122,
              'datavalue': 0,
              'name': 'Dragon Egg',
              'type': 'dragon_egg'
           },
           {
              'id': 123,
              'datavalue': 0,
              'name': 'Redstone Lamp (inactive)',
              'type': 'redstone_lamp'
           },
           {
              'id': 124,
              'datavalue': 0,
              'name': 'Redstone Lamp (active)',
              'type': 'lit_redstone_lamp'
           },
           {
              'id': 125,
              'datavalue': 0,
              'name': 'Double Oak Wood Slab',
              'type': 'double_wooden_slab'
           },
           {
              'id': 125,
              'datavalue': 1,
              'name': 'Double Spruce Wood Slab',
              'type': 'double_wooden_slab'
           },
           {
              'id': 125,
              'datavalue': 2,
              'name': 'Double Birch Wood Slab',
              'type': 'double_wooden_slab'
           },
           {
              'id': 125,
              'datavalue': 3,
              'name': 'Double Jungle Wood Slab',
              'type': 'double_wooden_slab'
           },
           {
              'id': 125,
              'datavalue': 4,
              'name': 'Double Acacia Wood Slab',
              'type': 'double_wooden_slab'
           },
           {
              'id': 125,
              'datavalue': 5,
              'name': 'Double Dark Oak Wood Slab',
              'type': 'double_wooden_slab'
           },
           {
              'id': 126,
              'datavalue': 0,
              'name': 'Oak Wood Slab',
              'type': 'wooden_slab'
           },
           {
              'id': 126,
              'datavalue': 1,
              'name': 'Spruce Wood Slab',
              'type': 'wooden_slab'
           },
           {
              'id': 126,
              'datavalue': 2,
              'name': 'Birch Wood Slab',
              'type': 'wooden_slab'
           },
           {
              'id': 126,
              'datavalue': 3,
              'name': 'Jungle Wood Slab',
              'type': 'wooden_slab'
           },
           {
              'id': 126,
              'datavalue': 4,
              'name': 'Acacia Wood Slab',
              'type': 'wooden_slab'
           },
           {
              'id': 126,
              'datavalue': 5,
              'name': 'Dark Oak Wood Slab',
              'type': 'wooden_slab'
           },
           {
              'id': 127,
              'datavalue': 0,
              'name': 'Cocoa',
              'type': 'cocoa'
           },
           {
              'id': 128,
              'datavalue': 0,
              'name': 'Sandstone Stairs',
              'type': 'sandstone_stairs'
           },
           {
              'id': 129,
              'datavalue': 0,
              'name': 'Emerald Ore',
              'type': 'emerald_ore'
           },
           {
              'id': 130,
              'datavalue': 0,
              'name': 'Ender Chest',
              'type': 'ender_chest'
           },
           {
              'id': 131,
              'datavalue': 0,
              'name': 'Tripwire Hook',
              'type': 'tripwire_hook'
           },
           {
              'id': 132,
              'datavalue': 0,
              'name': 'Tripwire',
              'type': 'tripwire_hook'
           },
           {
              'id': 133,
              'datavalue': 0,
              'name': 'Emerald Block',
              'type': 'emerald_block'
           },
           {
              'id': 134,
              'datavalue': 0,
              'name': 'Spruce Wood Stairs',
              'type': 'spruce_stairs'
           },
           {
              'id': 135,
              'datavalue': 0,
              'name': 'Birch Wood Stairs',
              'type': 'birch_stairs'
           },
           {
              'id': 136,
              'datavalue': 0,
              'name': 'Jungle Wood Stairs',
              'type': 'jungle_stairs'
           },
           {
              'id': 137,
              'datavalue': 0,
              'name': 'Command Block',
              'type': 'command_block'
           },
           {
              'id': 138,
              'datavalue': 0,
              'name': 'Beacon',
              'type': 'beacon'
           },
           {
              'id': 139,
              'datavalue': 0,
              'name': 'Cobblestone Wall',
              'type': 'cobblestone_wall'
           },
           {
              'id': 139,
              'datavalue': 1,
              'name': 'Mossy Cobblestone Wall',
              'type': 'cobblestone_wall'
           },
           {
              'id': 140,
              'datavalue': 0,
              'name': 'Flower Pot',
              'type': 'flower_pot'
           },
           {
              'id': 141,
              'datavalue': 0,
              'name': 'Carrots',
              'type': 'carrots'
           },
           {
              'id': 142,
              'datavalue': 0,
              'name': 'Potatoes',
              'type': 'potatoes'
           },
           {
              'id': 143,
              'datavalue': 0,
              'name': 'Wooden Button',
              'type': 'wooden_button'
           },
           {
              'id': 144,
              'datavalue': 0,
              'name': 'Mob Head',
              'type': 'skull'
           },
           {
              'id': 145,
              'datavalue': 0,
              'name': 'Anvil',
              'type': 'anvil'
           },
           {
              'id': 146,
              'datavalue': 0,
              'name': 'Trapped Chest',
              'type': 'trapped_chest'
           },
           {
              'id': 147,
              'datavalue': 0,
              'name': 'Weighted Pressure Plate (light)',
              'type': 'light_weighted_pressure_plate'
           },
           {
              'id': 148,
              'datavalue': 0,
              'name': 'Weighted Pressure Plate (heavy)',
              'type': 'heavy_weighted_pressure_plate'
           },
           {
              'id': 149,
              'datavalue': 0,
              'name': 'Redstone Comparator (inactive)',
              'type': 'unpowered_comparator'
           },
           {
              'id': 150,
              'datavalue': 0,
              'name': 'Redstone Comparator (active)',
              'type': 'powered_comparator'
           },
           {
              'id': 151,
              'datavalue': 0,
              'name': 'Daylight Sensor',
              'type': 'daylight_detector'
           },
           {
              'id': 152,
              'datavalue': 0,
              'name': 'Redstone Block',
              'type': 'redstone_block'
           },
           {
              'id': 153,
              'datavalue': 0,
              'name': 'Nether Quartz Ore',
              'type': 'quartz_ore'
           },
           {
              'id': 154,
              'datavalue': 0,
              'name': 'Hopper',
              'type': 'hopper'
           },
           {
              'id': 155,
              'datavalue': 0,
              'name': 'Quartz Block',
              'type': 'quartz_block'
           },
           {
              'id': 155,
              'datavalue': 1,
              'name': 'Chiseled Quartz Block',
              'type': 'quartz_block'
           },
           {
              'id': 155,
              'datavalue': 2,
              'name': 'Pillar Quartz Block',
              'type': 'quartz_block'
           },
           {
              'id': 156,
              'datavalue': 0,
              'name': 'Quartz Stairs',
              'type': 'quartz_stairs'
           },
           {
              'id': 157,
              'datavalue': 0,
              'name': 'Activator Rail',
              'type': 'activator_rail'
           },
           {
              'id': 158,
              'datavalue': 0,
              'name': 'Dropper',
              'type': 'dropper'
           },
           {
              'id': 159,
              'datavalue': 0,
              'name': 'White Hardened Clay',
              'type': 'stained_hardened_clay'
           },
           {
              'id': 159,
              'datavalue': 1,
              'name': 'Orange Hardened Clay',
              'type': 'stained_hardened_clay'
           },
           {
              'id': 159,
              'datavalue': 2,
              'name': 'Magenta Hardened Clay',
              'type': 'stained_hardened_clay'
           },
           {
              'id': 159,
              'datavalue': 3,
              'name': 'Light Blue Hardened Clay',
              'type': 'stained_hardened_clay'
           },
           {
              'id': 159,
              'datavalue': 4,
              'name': 'Yellow Hardened Clay',
              'type': 'stained_hardened_clay'
           },
           {
              'id': 159,
              'datavalue': 5,
              'name': 'Lime Hardened Clay',
              'type': 'stained_hardened_clay'
           },
           {
              'id': 159,
              'datavalue': 6,
              'name': 'Pink Hardened Clay',
              'type': 'stained_hardened_clay'
           },
           {
              'id': 159,
              'datavalue': 7,
              'name': 'Gray Hardened Clay',
              'type': 'stained_hardened_clay'
           },
           {
              'id': 159,
              'datavalue': 8,
              'name': 'Light Gray Hardened Clay',
              'type': 'stained_hardened_clay'
           },
           {
              'id': 159,
              'datavalue': 9,
              'name': 'Cyan Hardened Clay',
              'type': 'stained_hardened_clay'
           },
           {
              'id': 159,
              'datavalue': 10,
              'name': 'Purple Hardened Clay',
              'type': 'stained_hardened_clay'
           },
           {
              'id': 159,
              'datavalue': 11,
              'name': 'Blue Hardened Clay',
              'type': 'stained_hardened_clay'
           },
           {
              'id': 159,
              'datavalue': 12,
              'name': 'Brown Hardened Clay',
              'type': 'stained_hardened_clay'
           },
           {
              'id': 159,
              'datavalue': 13,
              'name': 'Green Hardened Clay',
              'type': 'stained_hardened_clay'
           },
           {
              'id': 159,
              'datavalue': 14,
              'name': 'Red Hardened Clay',
              'type': 'stained_hardened_clay'
           },
           {
              'id': 159,
              'datavalue': 15,
              'name': 'Black Hardened Clay',
              'type': 'stained_hardened_clay'
           },
           {
              'id': 160,
              'datavalue': 0,
              'name': 'White Stained Glass Pane',
              'type': 'stained_glass_pane'
           },
           {
              'id': 160,
              'datavalue': 1,
              'name': 'Orange Stained Glass Pane',
              'type': 'stained_glass_pane'
           },
           {
              'id': 160,
              'datavalue': 2,
              'name': 'Magenta Stained Glass Pane',
              'type': 'stained_glass_pane'
           },
           {
              'id': 160,
              'datavalue': 3,
              'name': 'Light Blue Stained Glass Pane',
              'type': 'stained_glass_pane'
           },
           {
              'id': 160,
              'datavalue': 4,
              'name': 'Yellow Stained Glass Pane',
              'type': 'stained_glass_pane'
           },
           {
              'id': 160,
              'datavalue': 5,
              'name': 'Lime Stained Glass Pane',
              'type': 'stained_glass_pane'
           },
           {
              'id': 160,
              'datavalue': 6,
              'name': 'Pink Stained Glass Pane',
              'type': 'stained_glass_pane'
           },
           {
              'id': 160,
              'datavalue': 7,
              'name': 'Gray Stained Glass Pane',
              'type': 'stained_glass_pane'
           },
           {
              'id': 160,
              'datavalue': 8,
              'name': 'Light Gray Stained Glass Pane',
              'type': 'stained_glass_pane'
           },
           {
              'id': 160,
              'datavalue': 9,
              'name': 'Cyan Stained Glass Pane',
              'type': 'stained_glass_pane'
           },
           {
              'id': 160,
              'datavalue': 10,
              'name': 'Purple Stained Glass Pane',
              'type': 'stained_glass_pane'
           },
           {
              'id': 160,
              'datavalue': 11,
              'name': 'Blue Stained Glass Pane',
              'type': 'stained_glass_pane'
           },
           {
              'id': 160,
              'datavalue': 12,
              'name': 'Brown Stained Glass Pane',
              'type': 'stained_glass_pane'
           },
           {
              'id': 160,
              'datavalue': 13,
              'name': 'Green Stained Glass Pane',
              'type': 'stained_glass_pane'
           },
           {
              'id': 160,
              'datavalue': 14,
              'name': 'Red Stained Glass Pane',
              'type': 'stained_glass_pane'
           },
           {
              'id': 160,
              'datavalue': 15,
              'name': 'Black Stained Glass Pane',
              'type': 'stained_glass_pane'
           },
           {
              'id': 161,
              'datavalue': 0,
              'name': 'Acacia Leaves',
              'type': 'leaves2'
           },
           {
              'id': 161,
              'datavalue': 1,
              'name': 'Dark Oak Leaves',
              'type': 'leaves2'
           },
           {
              'id': 162,
              'datavalue': 0,
              'name': 'Acacia Wood',
              'type': 'log2'
           },
           {
              'id': 162,
              'datavalue': 1,
              'name': 'Dark Oak Wood',
              'type': 'log2'
           },
           {
              'id': 163,
              'datavalue': 0,
              'name': 'Acacia Wood Stairs',
              'type': 'acacia_stairs'
           },
           {
              'id': 164,
              'datavalue': 0,
              'name': 'Dark Oak Wood Stairs',
              'type': 'dark_oak_stairs'
           },
           {
              'id': 165,
              'datavalue': 0,
              'name': 'Slime Block',
              'type': 'slime'
           },
           {
              'id': 166,
              'datavalue': 0,
              'name': 'Barrier',
              'type': 'barrier'
           },
           {
              'id': 167,
              'datavalue': 0,
              'name': 'Iron Trapdoor',
              'type': 'iron_trapdoor'
           },
           {
              'id': 168,
              'datavalue': 0,
              'name': 'Prismarine',
              'type': 'prismarine'
           },
           {
              'id': 168,
              'datavalue': 1,
              'name': 'Prismarine Bricks',
              'type': 'prismarine'
           },
           {
              'id': 168,
              'datavalue': 2,
              'name': 'Dark Prismarine',
              'type': 'prismarine'
           },
           {
              'id': 169,
              'datavalue': 0,
              'name': 'Sea Lantern',
              'type': 'sea_lantern'
           },
           {
              'id': 170,
              'datavalue': 0,
              'name': 'Hay Bale',
              'type': 'hay_block'
           },
           {
              'id': 171,
              'datavalue': 0,
              'name': 'White Carpet',
              'type': 'carpet'
           },
           {
              'id': 171,
              'datavalue': 1,
              'name': 'Orange Carpet',
              'type': 'carpet'
           },
           {
              'id': 171,
              'datavalue': 2,
              'name': 'Magenta Carpet',
              'type': 'carpet'
           },
           {
              'id': 171,
              'datavalue': 3,
              'name': 'Light Blue Carpet',
              'type': 'carpet'
           },
           {
              'id': 171,
              'datavalue': 4,
              'name': 'Yellow Carpet',
              'type': 'carpet'
           },
           {
              'id': 171,
              'datavalue': 5,
              'name': 'Lime Carpet',
              'type': 'carpet'
           },
           {
              'id': 171,
              'datavalue': 6,
              'name': 'Pink Carpet',
              'type': 'carpet'
           },
           {
              'id': 171,
              'datavalue': 7,
              'name': 'Gray Carpet',
              'type': 'carpet'
           },
           {
              'id': 171,
              'datavalue': 8,
              'name': 'Light Gray Carpet',
              'type': 'carpet'
           },
           {
              'id': 171,
              'datavalue': 9,
              'name': 'Cyan Carpet',
              'type': 'carpet'
           },
           {
              'id': 171,
              'datavalue': 10,
              'name': 'Purple Carpet',
              'type': 'carpet'
           },
           {
              'id': 171,
              'datavalue': 11,
              'name': 'Blue Carpet',
              'type': 'carpet'
           },
           {
              'id': 171,
              'datavalue': 12,
              'name': 'Brown Carpet',
              'type': 'carpet'
           },
           {
              'id': 171,
              'datavalue': 13,
              'name': 'Green Carpet',
              'type': 'carpet'
           },
           {
              'id': 171,
              'datavalue': 14,
              'name': 'Red Carpet',
              'type': 'carpet'
           },
           {
              'id': 171,
              'datavalue': 15,
              'name': 'Black Carpet',
              'type': 'carpet'
           },
           {
              'id': 172,
              'datavalue': 0,
              'name': 'Hardened Clay',
              'type': 'hardened_clay'
           },
           {
              'id': 173,
              'datavalue': 0,
              'name': 'Block of Coal',
              'type': 'coal_block'
           },
           {
              'id': 174,
              'datavalue': 0,
              'name': 'Packed Ice',
              'type': 'packed_ice'
           },
           {
              'id': 175,
              'datavalue': 0,
              'name': 'Sunflower',
              'type': 'double_plant'
           },
           {
              'id': 175,
              'datavalue': 1,
              'name': 'Lilac',
              'type': 'double_plant'
           },
           {
              'id': 175,
              'datavalue': 2,
              'name': 'Double Tallgrass',
              'type': 'double_plant'
           },
           {
              'id': 175,
              'datavalue': 3,
              'name': 'Large Fern',
              'type': 'double_plant'
           },
           {
              'id': 175,
              'datavalue': 4,
              'name': 'Rose Bush',
              'type': 'double_plant'
           },
           {
              'id': 175,
              'datavalue': 5,
              'name': 'Peony',
              'type': 'double_plant'
           },
           {
              'id': 176,
              'datavalue': 0,
              'name': 'Free-standing Banner',
              'type': 'standing_banner'
           },
           {
              'id': 177,
              'datavalue': 0,
              'name': 'Wall-mounted Banner',
              'type': 'wall_banner'
           },
           {
              'id': 178,
              'datavalue': 0,
              'name': 'Inverted Daylight Sensor',
              'type': 'daylight_detector_inverted'
           },
           {
              'id': 179,
              'datavalue': 0,
              'name': 'Red Sandstone',
              'type': 'red_sandstone'
           },
           {
              'id': 179,
              'datavalue': 1,
              'name': 'Chiseled Red Sandstone',
              'type': 'red_sandstone'
           },
           {
              'id': 179,
              'datavalue': 2,
              'name': 'Smooth Red Sandstone',
              'type': 'red_sandstone'
           },
           {
              'id': 180,
              'datavalue': 0,
              'name': 'Red Sandstone Stairs',
              'type': 'red_sandstone_stairs'
           },
           {
              'id': 181,
              'datavalue': 0,
              'name': 'Double Red Sandstone Slab',
              'type': 'double_stone_slab2'
           },
           {
              'id': 182,
              'datavalue': 0,
              'name': 'Red Sandstone Slab',
              'type': 'stone_slab2'
           },
           {
              'id': 183,
              'datavalue': 0,
              'name': 'Spruce Fence Gate',
              'type': 'spruce_fence_gate'
           },
           {
              'id': 184,
              'datavalue': 0,
              'name': 'Birch Fence Gate',
              'type': 'birch_fence_gate'
           },
           {
              'id': 185,
              'datavalue': 0,
              'name': 'Jungle Fence Gate',
              'type': 'jungle_fence_gate'
           },
           {
              'id': 186,
              'datavalue': 0,
              'name': 'Dark Oak Fence Gate',
              'type': 'dark_oak_fence_gate'
           },
           {
              'id': 187,
              'datavalue': 0,
              'name': 'Acacia Fence Gate',
              'type': 'acacia_fence_gate'
           },
           {
              'id': 188,
              'datavalue': 0,
              'name': 'Spruce Fence',
              'type': 'spruce_fence'
           },
           {
              'id': 189,
              'datavalue': 0,
              'name': 'Birch Fence',
              'type': 'birch_fence'
           },
           {
              'id': 190,
              'datavalue': 0,
              'name': 'Jungle Fence',
              'type': 'jungle_fence'
           },
           {
              'id': 191,
              'datavalue': 0,
              'name': 'Dark Oak Fence',
              'type': 'dark_oak_fence'
           },
           {
              'id': 192,
              'datavalue': 0,
              'name': 'Acacia Fence',
              'type': 'acacia_fence'
           },
           {
              'id': 193,
              'datavalue': 0,
              'name': 'Spruce Door Block',
              'type': 'spruce_door'
           },
           {
              'id': 194,
              'datavalue': 0,
              'name': 'Birch Door Block',
              'type': 'birch_door'
           },
           {
              'id': 195,
              'datavalue': 0,
              'name': 'Jungle Door Block',
              'type': 'jungle_door'
           },
           {
              'id': 196,
              'datavalue': 0,
              'name': 'Acacia Door Block',
              'type': 'acacia_door'
           },
           {
              'id': 197,
              'datavalue': 0,
              'name': 'Dark Oak Door Block',
              'type': 'dark_oak_door'
           },
           {
              'id': 198,
              'datavalue': 0,
              'name': 'End Rod',
              'type': 'end_rod'
           },
           {
              'id': 199,
              'datavalue': 0,
              'name': 'Chorus Plant',
              'type': 'chorus_plant'
           },
           {
              'id': 200,
              'datavalue': 0,
              'name': 'Chorus Flower',
              'type': 'chorus_flower'
           },
           {
              'id': 201,
              'datavalue': 0,
              'name': 'Purpur Block',
              'type': 'purpur_block'
           },
           {
              'id': 202,
              'datavalue': 0,
              'name': 'Purpur Pillar',
              'type': 'purpur_pillar'
           },
           {
              'id': 203,
              'datavalue': 0,
              'name': 'Purpur Stairs',
              'type': 'purpur_stairs'
           },
           {
              'id': 204,
              'datavalue': 0,
              'name': 'Purpur Double Slab',
              'type': 'purpur_double_slab'
           },
           {
              'id': 205,
              'datavalue': 0,
              'name': 'Purpur Slab',
              'type': 'purpur_slab'
           },
           {
              'id': 206,
              'datavalue': 0,
              'name': 'End Stone Bricks',
              'type': 'end_bricks'
           },
           {
              'id': 207,
              'datavalue': 0,
              'name': 'Beetroot Block',
              'type': 'beetroots'
           },
           {
              'id': 208,
              'datavalue': 0,
              'name': 'Grass Path',
              'type': 'grass_path'
           },
           {
              'id': 209,
              'datavalue': 0,
              'name': 'End Gateway',
              'type': 'end_gateway'
           },
           {
              'id': 210,
              'datavalue': 0,
              'name': 'Repeating Command Block',
              'type': 'repeating_command_block'
           },
           {
              'id': 211,
              'datavalue': 0,
              'name': 'Chain Command Block',
              'type': 'chain_command_block'
           },
           {
              'id': 212,
              'datavalue': 0,
              'name': 'Frosted Ice',
              'type': 'frosted_ice'
           },
           {
              'id': 213,
              'datavalue': 0,
              'name': 'Magma Block',
              'type': 'magma'
           },
           {
              'id': 214,
              'datavalue': 0,
              'name': 'Nether Wart Block',
              'type': 'nether_wart_block'
           },
           {
              'id': 215,
              'datavalue': 0,
              'name': 'Red Nether Brick',
              'type': 'red_nether_brick'
           },
           {
              'id': 216,
              'datavalue': 0,
              'name': 'Bone Block',
              'type': 'bone_block'
           },
           {
              'id': 217,
              'datavalue': 0,
              'name': 'Structure Void',
              'type': 'structure_void'
           },
           {
              'id': 218,
              'datavalue': 0,
              'name': 'Observer',
              'type': 'observer'
           },
           {
              'id': 219,
              'datavalue': 0,
              'name': 'White Shulker Box',
              'type': 'white_shulker_box'
           },
           {
              'id': 220,
              'datavalue': 0,
              'name': 'Orange Shulker Box',
              'type': 'orange_shulker_box'
           },
           {
              'id': 221,
              'datavalue': 0,
              'name': 'Magenta Shulker Box',
              'type': 'magenta_shulker_box'
           },
           {
              'id': 222,
              'datavalue': 0,
              'name': 'Light Blue Shulker Box',
              'type': 'light_blue_shulker_box'
           },
           {
              'id': 223,
              'datavalue': 0,
              'name': 'Yellow Shulker Box',
              'type': 'yellow_shulker_box'
           },
           {
              'id': 224,
              'datavalue': 0,
              'name': 'Lime Shulker Box',
              'type': 'lime_shulker_box'
           },
           {
              'id': 225,
              'datavalue': 0,
              'name': 'Pink Shulker Box',
              'type': 'pink_shulker_box'
           },
           {
              'id': 226,
              'datavalue': 0,
              'name': 'Gray Shulker Box',
              'type': 'gray_shulker_box'
           },
           {
              'id': 227,
              'datavalue': 0,
              'name': 'Light Gray Shulker Box',
              'type': 'silver_shulker_box'
           },
           {
              'id': 228,
              'datavalue': 0,
              'name': 'Cyan Shulker Box',
              'type': 'cyan_shulker_box'
           },
           {
              'id': 229,
              'datavalue': 0,
              'name': 'Purple Shulker Box',
              'type': 'purple_shulker_box'
           },
           {
              'id': 230,
              'datavalue': 0,
              'name': 'Blue Shulker Box',
              'type': 'blue_shulker_box'
           },
           {
              'id': 231,
              'datavalue': 0,
              'name': 'Brown Shulker Box',
              'type': 'brown_shulker_box'
           },
           {
              'id': 232,
              'datavalue': 0,
              'name': 'Green Shulker Box',
              'type': 'green_shulker_box'
           },
           {
              'id': 233,
              'datavalue': 0,
              'name': 'Red Shulker Box',
              'type': 'red_shulker_box'
           },
           {
              'id': 234,
              'datavalue': 0,
              'name': 'Black Shulker Box',
              'type': 'black_shulker_box'
           },
           {
              'id': 235,
              'datavalue': 0,
              'name': 'White Glazed Terracotta',
              'type': 'white_glazed_terracotta'
           },
           {
              'id': 236,
              'datavalue': 0,
              'name': 'Orange Glazed Terracotta',
              'type': 'orange_glazed_terracotta'
           },
           {
              'id': 237,
              'datavalue': 0,
              'name': 'Magenta Glazed Terracotta',
              'type': 'magenta_glazed_terracotta'
           },
           {
              'id': 238,
              'datavalue': 0,
              'name': 'Light Blue Glazed Terracotta',
              'type': 'light_blue_glazed_terracotta'
           },
           {
              'id': 239,
              'datavalue': 0,
              'name': 'Yellow Glazed Terracotta',
              'type': 'yellow_glazed_terracotta'
           },
           {
              'id': 240,
              'datavalue': 0,
              'name': 'Lime Glazed Terracotta',
              'type': 'lime_glazed_terracotta'
           },
           {
              'id': 241,
              'datavalue': 0,
              'name': 'Pink Glazed Terracotta',
              'type': 'pink_glazed_terracotta'
           },
           {
              'id': 242,
              'datavalue': 0,
              'name': 'Gray Glazed Terracotta',
              'type': 'gray_glazed_terracotta'
           },
           {
              'id': 243,
              'datavalue': 0,
              'name': 'Light Gray Glazed Terracotta',
              'type': 'light_gray_glazed_terracotta'
           },
           {
              'id': 244,
              'datavalue': 0,
              'name': 'Cyan Glazed Terracotta',
              'type': 'cyan_glazed_terracotta'
           },
           {
              'id': 245,
              'datavalue': 0,
              'name': 'Purple Glazed Terracotta',
              'type': 'purple_glazed_terracotta'
           },
           {
              'id': 246,
              'datavalue': 0,
              'name': 'Blue Glazed Terracotta',
              'type': 'blue_glazed_terracotta'
           },
           {
              'id': 247,
              'datavalue': 0,
              'name': 'Brown Glazed Terracotta',
              'type': 'brown_glazed_terracotta'
           },
           {
              'id': 248,
              'datavalue': 0,
              'name': 'Green Glazed Terracotta',
              'type': 'green_glazed_terracotta'
           },
           {
              'id': 249,
              'datavalue': 0,
              'name': 'Red Glazed Terracotta',
              'type': 'red_glazed_terracotta'
           },
           {
              'id': 250,
              'datavalue': 0,
              'name': 'Black Glazed Terracotta',
              'type': 'black_glazed_terracotta'
           },
           {
              'id': 251,
              'datavalue': 0,
              'name': 'White Concrete',
              'type': 'concrete'
           },
           {
              'id': 251,
              'datavalue': 1,
              'name': 'Orange Concrete',
              'type': 'concrete'
           },
           {
              'id': 251,
              'datavalue': 2,
              'name': 'Magenta Concrete',
              'type': 'concrete'
           },
           {
              'id': 251,
              'datavalue': 3,
              'name': 'Light Blue Concrete',
              'type': 'concrete'
           },
           {
              'id': 251,
              'datavalue': 4,
              'name': 'Yellow Concrete',
              'type': 'concrete'
           },
           {
              'id': 251,
              'datavalue': 5,
              'name': 'Lime Concrete',
              'type': 'concrete'
           },
           {
              'id': 251,
              'datavalue': 6,
              'name': 'Pink Concrete',
              'type': 'concrete'
           },
           {
              'id': 251,
              'datavalue': 7,
              'name': 'Gray Concrete',
              'type': 'concrete'
           },
           {
              'id': 251,
              'datavalue': 8,
              'name': 'Light Gray Concrete',
              'type': 'concrete'
           },
           {
              'id': 251,
              'datavalue': 9,
              'name': 'Cyan Concrete',
              'type': 'concrete'
           },
           {
              'id': 251,
              'datavalue': 10,
              'name': 'Purple Concrete',
              'type': 'concrete'
           },
           {
              'id': 251,
              'datavalue': 11,
              'name': 'Blue Concrete',
              'type': 'concrete'
           },
           {
              'id': 251,
              'datavalue': 12,
              'name': 'Brown Concrete',
              'type': 'concrete'
           },
           {
              'id': 251,
              'datavalue': 13,
              'name': 'Green Concrete',
              'type': 'concrete'
           },
           {
              'id': 251,
              'datavalue': 14,
              'name': 'Red Concrete',
              'type': 'concrete'
           },
           {
              'id': 251,
              'datavalue': 15,
              'name': 'Black Concrete',
              'type': 'concrete'
           },
           {
              'id': 252,
              'datavalue': 0,
              'name': 'White Concrete Powder',
              'type': 'concrete_powder'
           },
           {
              'id': 252,
              'datavalue': 1,
              'name': 'Orange Concrete Powder',
              'type': 'concrete_powder'
           },
           {
              'id': 252,
              'datavalue': 2,
              'name': 'Magenta Concrete Powder',
              'type': 'concrete_powder'
           },
           {
              'id': 252,
              'datavalue': 3,
              'name': 'Light Blue Concrete Powder',
              'type': 'concrete_powder'
           },
           {
              'id': 252,
              'datavalue': 4,
              'name': 'Yellow Concrete Powder',
              'type': 'concrete_powder'
           },
           {
              'id': 252,
              'datavalue': 5,
              'name': 'Lime Concrete Powder',
              'type': 'concrete_powder'
           },
           {
              'id': 252,
              'datavalue': 6,
              'name': 'Pink Concrete Powder',
              'type': 'concrete_powder'
           },
           {
              'id': 252,
              'datavalue': 7,
              'name': 'Gray Concrete Powder',
              'type': 'concrete_powder'
           },
           {
              'id': 252,
              'datavalue': 8,
              'name': 'Light Gray Concrete Powder',
              'type': 'concrete_powder'
           },
           {
              'id': 252,
              'datavalue': 9,
              'name': 'Cyan Concrete Powder',
              'type': 'concrete_powder'
           },
           {
              'id': 252,
              'datavalue': 10,
              'name': 'Purple Concrete Powder',
              'type': 'concrete_powder'
           },
           {
              'id': 252,
              'datavalue': 11,
              'name': 'Blue Concrete Powder',
              'type': 'concrete_powder'
           },
           {
              'id': 252,
              'datavalue': 12,
              'name': 'Brown Concrete Powder',
              'type': 'concrete_powder'
           },
           {
              'id': 252,
              'datavalue': 13,
              'name': 'Green Concrete Powder',
              'type': 'concrete_powder'
           },
           {
              'id': 252,
              'datavalue': 14,
              'name': 'Red Concrete Powder',
              'type': 'concrete_powder'
           },
           {
              'id': 252,
              'datavalue': 15,
              'name': 'Black Concrete Powder',
              'type': 'concrete_powder'
           },
           {
              'id': 255,
              'datavalue': 0,
              'name': 'Structure Block',
              'type': 'structure_block'
           },
           {
              'id': 256,
              'datavalue': 0,
              'name': 'Iron Shovel',
              'type': 'iron_shovel'
           },
           {
              'id': 257,
              'datavalue': 0,
              'name': 'Iron Pickaxe',
              'type': 'iron_pickaxe'
           },
           {
              'id': 258,
              'datavalue': 0,
              'name': 'Iron Axe',
              'type': 'iron_axe'
           },
           {
              'id': 259,
              'datavalue': 0,
              'name': 'Flint and Steel',
              'type': 'flint_and_steel'
           },
           {
              'id': 260,
              'datavalue': 0,
              'name': 'Apple',
              'type': 'apple'
           },
           {
              'id': 261,
              'datavalue': 0,
              'name': 'Bow',
              'type': 'bow'
           },
           {
              'id': 262,
              'datavalue': 0,
              'name': 'Arrow',
              'type': 'arrow'
           },
           {
              'id': 263,
              'datavalue': 0,
              'name': 'Coal',
              'type': 'coal'
           },
           {
              'id': 263,
              'datavalue': 1,
              'name': 'Charcoal',
              'type': 'coal'
           },
           {
              'id': 264,
              'datavalue': 0,
              'name': 'Diamond',
              'type': 'diamond'
           },
           {
              'id': 265,
              'datavalue': 0,
              'name': 'Iron Ingot',
              'type': 'iron_ingot'
           },
           {
              'id': 266,
              'datavalue': 0,
              'name': 'Gold Ingot',
              'type': 'gold_ingot'
           },
           {
              'id': 267,
              'datavalue': 0,
              'name': 'Iron Sword',
              'type': 'iron_sword'
           },
           {
              'id': 268,
              'datavalue': 0,
              'name': 'Wooden Sword',
              'type': 'wooden_sword'
           },
           {
              'id': 269,
              'datavalue': 0,
              'name': 'Wooden Shovel',
              'type': 'wooden_shovel'
           },
           {
              'id': 270,
              'datavalue': 0,
              'name': 'Wooden Pickaxe',
              'type': 'wooden_pickaxe'
           },
           {
              'id': 271,
              'datavalue': 0,
              'name': 'Wooden Axe',
              'type': 'wooden_axe'
           },
           {
              'id': 272,
              'datavalue': 0,
              'name': 'Stone Sword',
              'type': 'stone_sword'
           },
           {
              'id': 273,
              'datavalue': 0,
              'name': 'Stone Shovel',
              'type': 'stone_shovel'
           },
           {
              'id': 274,
              'datavalue': 0,
              'name': 'Stone Pickaxe',
              'type': 'stone_pickaxe'
           },
           {
              'id': 275,
              'datavalue': 0,
              'name': 'Stone Axe',
              'type': 'stone_axe'
           },
           {
              'id': 276,
              'datavalue': 0,
              'name': 'Diamond Sword',
              'type': 'diamond_sword'
           },
           {
              'id': 277,
              'datavalue': 0,
              'name': 'Diamond Shovel',
              'type': 'diamond_shovel'
           },
           {
              'id': 278,
              'datavalue': 0,
              'name': 'Diamond Pickaxe',
              'type': 'diamond_pickaxe'
           },
           {
              'id': 279,
              'datavalue': 0,
              'name': 'Diamond Axe',
              'type': 'diamond_axe'
           },
           {
              'id': 280,
              'datavalue': 0,
              'name': 'Stick',
              'type': 'stick'
           },
           {
              'id': 281,
              'datavalue': 0,
              'name': 'Bowl',
              'type': 'bowl'
           },
           {
              'id': 282,
              'datavalue': 0,
              'name': 'Mushroom Stew',
              'type': 'mushroom_stew'
           },
           {
              'id': 283,
              'datavalue': 0,
              'name': 'Golden Sword',
              'type': 'golden_sword'
           },
           {
              'id': 284,
              'datavalue': 0,
              'name': 'Golden Shovel',
              'type': 'golden_shovel'
           },
           {
              'id': 285,
              'datavalue': 0,
              'name': 'Golden Pickaxe',
              'type': 'golden_pickaxe'
           },
           {
              'id': 286,
              'datavalue': 0,
              'name': 'Golden Axe',
              'type': 'golden_axe'
           },
           {
              'id': 287,
              'datavalue': 0,
              'name': 'String',
              'type': 'string'
           },
           {
              'id': 288,
              'datavalue': 0,
              'name': 'Feather',
              'type': 'feather'
           },
           {
              'id': 289,
              'datavalue': 0,
              'name': 'Gunpowder',
              'type': 'gunpowder'
           },
           {
              'id': 290,
              'datavalue': 0,
              'name': 'Wooden Hoe',
              'type': 'wooden_hoe'
           },
           {
              'id': 291,
              'datavalue': 0,
              'name': 'Stone Hoe',
              'type': 'stone_hoe'
           },
           {
              'id': 292,
              'datavalue': 0,
              'name': 'Iron Hoe',
              'type': 'iron_hoe'
           },
           {
              'id': 293,
              'datavalue': 0,
              'name': 'Diamond Hoe',
              'type': 'diamond_hoe'
           },
           {
              'id': 294,
              'datavalue': 0,
              'name': 'Golden Hoe',
              'type': 'golden_hoe'
           },
           {
              'id': 295,
              'datavalue': 0,
              'name': 'Wheat Seeds',
              'type': 'wheat_seeds'
           },
           {
              'id': 296,
              'datavalue': 0,
              'name': 'Wheat',
              'type': 'wheat'
           },
           {
              'id': 297,
              'datavalue': 0,
              'name': 'Bread',
              'type': 'bread'
           },
           {
              'id': 298,
              'datavalue': 0,
              'name': 'Leather Helmet',
              'type': 'leather_helmet'
           },
           {
              'id': 299,
              'datavalue': 0,
              'name': 'Leather Tunic',
              'type': 'leather_chestplate'
           },
           {
              'id': 300,
              'datavalue': 0,
              'name': 'Leather Pants',
              'type': 'leather_leggings'
           },
           {
              'id': 301,
              'datavalue': 0,
              'name': 'Leather Boots',
              'type': 'leather_boots'
           },
           {
              'id': 302,
              'datavalue': 0,
              'name': 'Chainmail Helmet',
              'type': 'chainmail_helmet'
           },
           {
              'id': 303,
              'datavalue': 0,
              'name': 'Chainmail Chestplate',
              'type': 'chainmail_chestplate'
           },
           {
              'id': 304,
              'datavalue': 0,
              'name': 'Chainmail Leggings',
              'type': 'chainmail_leggings'
           },
           {
              'id': 305,
              'datavalue': 0,
              'name': 'Chainmail Boots',
              'type': 'chainmail_boots'
           },
           {
              'id': 306,
              'datavalue': 0,
              'name': 'Iron Helmet',
              'type': 'iron_helmet'
           },
           {
              'id': 307,
              'datavalue': 0,
              'name': 'Iron Chestplate',
              'type': 'iron_chestplate'
           },
           {
              'id': 308,
              'datavalue': 0,
              'name': 'Iron Leggings',
              'type': 'iron_leggings'
           },
           {
              'id': 309,
              'datavalue': 0,
              'name': 'Iron Boots',
              'type': 'iron_boots'
           },
           {
              'id': 310,
              'datavalue': 0,
              'name': 'Diamond Helmet',
              'type': 'diamond_helmet'
           },
           {
              'id': 311,
              'datavalue': 0,
              'name': 'Diamond Chestplate',
              'type': 'diamond_chestplate'
           },
           {
              'id': 312,
              'datavalue': 0,
              'name': 'Diamond Leggings',
              'type': 'diamond_leggings'
           },
           {
              'id': 313,
              'datavalue': 0,
              'name': 'Diamond Boots',
              'type': 'diamond_boots'
           },
           {
              'id': 314,
              'datavalue': 0,
              'name': 'Golden Helmet',
              'type': 'golden_helmet'
           },
           {
              'id': 315,
              'datavalue': 0,
              'name': 'Golden Chestplate',
              'type': 'golden_chestplate'
           },
           {
              'id': 316,
              'datavalue': 0,
              'name': 'Golden Leggings',
              'type': 'golden_leggings'
           },
           {
              'id': 317,
              'datavalue': 0,
              'name': 'Golden Boots',
              'type': 'golden_boots'
           },
           {
              'id': 318,
              'datavalue': 0,
              'name': 'Flint',
              'type': 'flint'
           },
           {
              'id': 319,
              'datavalue': 0,
              'name': 'Raw Porkchop',
              'type': 'porkchop'
           },
           {
              'id': 320,
              'datavalue': 0,
              'name': 'Cooked Porkchop',
              'type': 'cooked_porkchop'
           },
           {
              'id': 321,
              'datavalue': 0,
              'name': 'Painting',
              'type': 'painting'
           },
           {
              'id': 322,
              'datavalue': 0,
              'name': 'Golden Apple',
              'type': 'golden_apple'
           },
           {
              'id': 322,
              'datavalue': 1,
              'name': 'Enchanted Golden Apple',
              'type': 'golden_apple'
           },
           {
              'id': 323,
              'datavalue': 0,
              'name': 'Sign',
              'type': 'sign'
           },
           {
              'id': 324,
              'datavalue': 0,
              'name': 'Oak Door',
              'type': 'wooden_door'
           },
           {
              'id': 325,
              'datavalue': 0,
              'name': 'Bucket',
              'type': 'bucket'
           },
           {
              'id': 326,
              'datavalue': 0,
              'name': 'Water Bucket',
              'type': 'water_bucket'
           },
           {
              'id': 327,
              'datavalue': 0,
              'name': 'Lava Bucket',
              'type': 'lava_bucket'
           },
           {
              'id': 328,
              'datavalue': 0,
              'name': 'Minecart',
              'type': 'minecart'
           },
           {
              'id': 329,
              'datavalue': 0,
              'name': 'Saddle',
              'type': 'saddle'
           },
           {
              'id': 330,
              'datavalue': 0,
              'name': 'Iron Door',
              'type': 'iron_door'
           },
           {
              'id': 331,
              'datavalue': 0,
              'name': 'Redstone',
              'type': 'redstone'
           },
           {
              'id': 332,
              'datavalue': 0,
              'name': 'Snowball',
              'type': 'snowball'
           },
           {
              'id': 333,
              'datavalue': 0,
              'name': 'Oak Boat',
              'type': 'boat'
           },
           {
              'id': 334,
              'datavalue': 0,
              'name': 'Leather',
              'type': 'leather'
           },
           {
              'id': 335,
              'datavalue': 0,
              'name': 'Milk Bucket',
              'type': 'milk_bucket'
           },
           {
              'id': 336,
              'datavalue': 0,
              'name': 'Brick',
              'type': 'brick'
           },
           {
              'id': 337,
              'datavalue': 0,
              'name': 'Clay',
              'type': 'clay_ball'
           },
           {
              'id': 338,
              'datavalue': 0,
              'name': 'Sugar Canes',
              'type': 'reeds'
           },
           {
              'id': 339,
              'datavalue': 0,
              'name': 'Paper',
              'type': 'paper'
           },
           {
              'id': 340,
              'datavalue': 0,
              'name': 'Book',
              'type': 'book'
           },
           {
              'id': 341,
              'datavalue': 0,
              'name': 'Slimeball',
              'type': 'slime_ball'
           },
           {
              'id': 342,
              'datavalue': 0,
              'name': 'Minecart with Chest',
              'type': 'chest_minecart'
           },
           {
              'id': 343,
              'datavalue': 0,
              'name': 'Minecart with Furnace',
              'type': 'furnace_minecart'
           },
           {
              'id': 344,
              'datavalue': 0,
              'name': 'Egg',
              'type': 'egg'
           },
           {
              'id': 345,
              'datavalue': 0,
              'name': 'Compass',
              'type': 'compass'
           },
           {
              'id': 346,
              'datavalue': 0,
              'name': 'Fishing Rod',
              'type': 'fishing_rod'
           },
           {
              'id': 347,
              'datavalue': 0,
              'name': 'Clock',
              'type': 'clock'
           },
           {
              'id': 348,
              'datavalue': 0,
              'name': 'Glowstone Dust',
              'type': 'glowstone_dust'
           },
           {
              'id': 349,
              'datavalue': 0,
              'name': 'Raw Fish',
              'type': 'fish'
           },
           {
              'id': 349,
              'datavalue': 1,
              'name': 'Raw Salmon',
              'type': 'fish'
           },
           {
              'id': 349,
              'datavalue': 2,
              'name': 'Clownfish',
              'type': 'fish'
           },
           {
              'id': 349,
              'datavalue': 3,
              'name': 'Pufferfish',
              'type': 'fish'
           },
           {
              'id': 350,
              'datavalue': 0,
              'name': 'Cooked Fish',
              'type': 'cooked_fish'
           },
           {
              'id': 350,
              'datavalue': 1,
              'name': 'Cooked Salmon',
              'type': 'cooked_fish'
           },
           {
              'id': 351,
              'datavalue': 0,
              'name': 'Ink Sack',
              'type': 'dye'
           },
           {
              'id': 351,
              'datavalue': 1,
              'name': 'Rose Red',
              'type': 'dye'
           },
           {
              'id': 351,
              'datavalue': 2,
              'name': 'Cactus Green',
              'type': 'dye'
           },
           {
              'id': 351,
              'datavalue': 3,
              'name': 'Coco Beans',
              'type': 'dye'
           },
           {
              'id': 351,
              'datavalue': 4,
              'name': 'Lapis Lazuli',
              'type': 'dye'
           },
           {
              'id': 351,
              'datavalue': 5,
              'name': 'Purple Dye',
              'type': 'dye'
           },
           {
              'id': 351,
              'datavalue': 6,
              'name': 'Cyan Dye',
              'type': 'dye'
           },
           {
              'id': 351,
              'datavalue': 7,
              'name': 'Light Gray Dye',
              'type': 'dye'
           },
           {
              'id': 351,
              'datavalue': 8,
              'name': 'Gray Dye',
              'type': 'dye'
           },
           {
              'id': 351,
              'datavalue': 9,
              'name': 'Pink Dye',
              'type': 'dye'
           },
           {
              'id': 351,
              'datavalue': 10,
              'name': 'Lime Dye',
              'type': 'dye'
           },
           {
              'id': 351,
              'datavalue': 11,
              'name': 'Dandelion Yellow',
              'type': 'dye'
           },
           {
              'id': 351,
              'datavalue': 12,
              'name': 'Light Blue Dye',
              'type': 'dye'
           },
           {
              'id': 351,
              'datavalue': 13,
              'name': 'Magenta Dye',
              'type': 'dye'
           },
           {
              'id': 351,
              'datavalue': 14,
              'name': 'Orange Dye',
              'type': 'dye'
           },
           {
              'id': 351,
              'datavalue': 15,
              'name': 'Bone Meal',
              'type': 'dye'
           },
           {
              'id': 352,
              'datavalue': 0,
              'name': 'Bone',
              'type': 'bone'
           },
           {
              'id': 353,
              'datavalue': 0,
              'name': 'Sugar',
              'type': 'sugar'
           },
           {
              'id': 354,
              'datavalue': 0,
              'name': 'Cake',
              'type': 'cake'
           },
           {
              'id': 355,
              'datavalue': 0,
              'name': 'Bed',
              'type': 'bed'
           },
           {
              'id': 356,
              'datavalue': 0,
              'name': 'Redstone Repeater',
              'type': 'repeater'
           },
           {
              'id': 357,
              'datavalue': 0,
              'name': 'Cookie',
              'type': 'cookie'
           },
           {
              'id': 358,
              'datavalue': 0,
              'name': 'Map',
              'type': 'filled_map'
           },
           {
              'id': 359,
              'datavalue': 0,
              'name': 'Shears',
              'type': 'shears'
           },
           {
              'id': 360,
              'datavalue': 0,
              'name': 'Melon',
              'type': 'melon'
           },
           {
              'id': 361,
              'datavalue': 0,
              'name': 'Pumpkin Seeds',
              'type': 'pumpkin_seeds'
           },
           {
              'id': 362,
              'datavalue': 0,
              'name': 'Melon Seeds',
              'type': 'melon_seeds'
           },
           {
              'id': 363,
              'datavalue': 0,
              'name': 'Raw Beef',
              'type': 'beef'
           },
           {
              'id': 364,
              'datavalue': 0,
              'name': 'Steak',
              'type': 'cooked_beef'
           },
           {
              'id': 365,
              'datavalue': 0,
              'name': 'Raw Chicken',
              'type': 'chicken'
           },
           {
              'id': 366,
              'datavalue': 0,
              'name': 'Cooked Chicken',
              'type': 'cooked_chicken'
           },
           {
              'id': 367,
              'datavalue': 0,
              'name': 'Rotten Flesh',
              'type': 'rotten_flesh'
           },
           {
              'id': 368,
              'datavalue': 0,
              'name': 'Ender Pearl',
              'type': 'ender_pearl'
           },
           {
              'id': 369,
              'datavalue': 0,
              'name': 'Blaze Rod',
              'type': 'blaze_rod'
           },
           {
              'id': 370,
              'datavalue': 0,
              'name': 'Ghast Tear',
              'type': 'ghast_tear'
           },
           {
              'id': 371,
              'datavalue': 0,
              'name': 'Gold Nugget',
              'type': 'gold_nugget'
           },
           {
              'id': 372,
              'datavalue': 0,
              'name': 'Nether Wart',
              'type': 'nether_wart'
           },
           {
              'id': 373,
              'datavalue': 0,
              'name': 'Potion',
              'type': 'potion'
           },
           {
              'id': 374,
              'datavalue': 0,
              'name': 'Glass Bottle',
              'type': 'glass_bottle'
           },
           {
              'id': 375,
              'datavalue': 0,
              'name': 'Spider Eye',
              'type': 'spider_eye'
           },
           {
              'id': 376,
              'datavalue': 0,
              'name': 'Fermented Spider Eye',
              'type': 'fermented_spider_eye'
           },
           {
              'id': 377,
              'datavalue': 0,
              'name': 'Blaze Powder',
              'type': 'blaze_powder'
           },
           {
              'id': 378,
              'datavalue': 0,
              'name': 'Magma Cream',
              'type': 'magma_cream'
           },
           {
              'id': 379,
              'datavalue': 0,
              'name': 'Brewing Stand',
              'type': 'brewing_stand'
           },
           {
              'id': 380,
              'datavalue': 0,
              'name': 'Cauldron',
              'type': 'cauldron'
           },
           {
              'id': 381,
              'datavalue': 0,
              'name': 'Eye of Ender',
              'type': 'ender_eye'
           },
           {
              'id': 382,
              'datavalue': 0,
              'name': 'Glistering Melon',
              'type': 'speckled_melon'
           },
           {
              'id': 383,
              'datavalue': 4,
              'name': 'Spawn Elder Guardian',
              'type': 'spawn_egg'
           },
           {
              'id': 383,
              'datavalue': 5,
              'name': 'Spawn Wither Skeleton',
              'type': 'spawn_egg'
           },
           {
              'id': 383,
              'datavalue': 6,
              'name': 'Spawn Stray',
              'type': 'spawn_egg'
           },
           {
              'id': 383,
              'datavalue': 23,
              'name': 'Spawn Husk',
              'type': 'spawn_egg'
           },
           {
              'id': 383,
              'datavalue': 27,
              'name': 'Spawn Zombie Villager',
              'type': 'spawn_egg'
           },
           {
              'id': 383,
              'datavalue': 28,
              'name': 'Spawn Skeleton Horse',
              'type': 'spawn_egg'
           },
           {
              'id': 383,
              'datavalue': 29,
              'name': 'Spawn Zombie Horse',
              'type': 'spawn_egg'
           },
           {
              'id': 383,
              'datavalue': 31,
              'name': 'Spawn Donkey',
              'type': 'spawn_egg'
           },
           {
              'id': 383,
              'datavalue': 32,
              'name': 'Spawn Mule',
              'type': 'spawn_egg'
           },
           {
              'id': 383,
              'datavalue': 34,
              'name': 'Spawn Evoker',
              'type': 'spawn_egg'
           },
           {
              'id': 383,
              'datavalue': 35,
              'name': 'Spawn Vex',
              'type': 'spawn_egg'
           },
           {
              'id': 383,
              'datavalue': 36,
              'name': 'Spawn Vindicator',
              'type': 'spawn_egg'
           },
           {
              'id': 383,
              'datavalue': 50,
              'name': 'Spawn Creeper',
              'type': 'spawn_egg'
           },
           {
              'id': 383,
              'datavalue': 51,
              'name': 'Spawn Skeleton',
              'type': 'spawn_egg'
           },
           {
              'id': 383,
              'datavalue': 52,
              'name': 'Spawn Spider',
              'type': 'spawn_egg'
           },
           {
              'id': 383,
              'datavalue': 54,
              'name': 'Spawn Zombie',
              'type': 'spawn_egg'
           },
           {
              'id': 383,
              'datavalue': 55,
              'name': 'Spawn Slime',
              'type': 'spawn_egg'
           },
           {
              'id': 383,
              'datavalue': 56,
              'name': 'Spawn Ghast',
              'type': 'spawn_egg'
           },
           {
              'id': 383,
              'datavalue': 57,
              'name': 'Spawn Zombie Pigman',
              'type': 'spawn_egg'
           },
           {
              'id': 383,
              'datavalue': 58,
              'name': 'Spawn Enderman',
              'type': 'spawn_egg'
           },
           {
              'id': 383,
              'datavalue': 59,
              'name': 'Spawn Cave Spider',
              'type': 'spawn_egg'
           },
           {
              'id': 383,
              'datavalue': 60,
              'name': 'Spawn Silverfish',
              'type': 'spawn_egg'
           },
           {
              'id': 383,
              'datavalue': 61,
              'name': 'Spawn Blaze',
              'type': 'spawn_egg'
           },
           {
              'id': 383,
              'datavalue': 62,
              'name': 'Spawn Magma Cube',
              'type': 'spawn_egg'
           },
           {
              'id': 383,
              'datavalue': 65,
              'name': 'Spawn Bat',
              'type': 'spawn_egg'
           },
           {
              'id': 383,
              'datavalue': 66,
              'name': 'Spawn Witch',
              'type': 'spawn_egg'
           },
           {
              'id': 383,
              'datavalue': 67,
              'name': 'Spawn Endermite',
              'type': 'spawn_egg'
           },
           {
              'id': 383,
              'datavalue': 68,
              'name': 'Spawn Guardian',
              'type': 'spawn_egg'
           },
           {
              'id': 383,
              'datavalue': 69,
              'name': 'Spawn Shulker',
              'type': 'spawn_egg'
           },
           {
              'id': 383,
              'datavalue': 90,
              'name': 'Spawn Pig',
              'type': 'spawn_egg'
           },
           {
              'id': 383,
              'datavalue': 91,
              'name': 'Spawn Sheep',
              'type': 'spawn_egg'
           },
           {
              'id': 383,
              'datavalue': 92,
              'name': 'Spawn Cow',
              'type': 'spawn_egg'
           },
           {
              'id': 383,
              'datavalue': 93,
              'name': 'Spawn Chicken',
              'type': 'spawn_egg'
           },
           {
              'id': 383,
              'datavalue': 94,
              'name': 'Spawn Squid',
              'type': 'spawn_egg'
           },
           {
              'id': 383,
              'datavalue': 95,
              'name': 'Spawn Wolf',
              'type': 'spawn_egg'
           },
           {
              'id': 383,
              'datavalue': 96,
              'name': 'Spawn Mooshroom',
              'type': 'spawn_egg'
           },
           {
              'id': 383,
              'datavalue': 98,
              'name': 'Spawn Ocelot',
              'type': 'spawn_egg'
           },
           {
              'id': 383,
              'datavalue': 100,
              'name': 'Spawn Horse',
              'type': 'spawn_egg'
           },
           {
              'id': 383,
              'datavalue': 101,
              'name': 'Spawn Rabbit',
              'type': 'spawn_egg'
           },
           {
              'id': 383,
              'datavalue': 102,
              'name': 'Spawn Polar Bear',
              'type': 'spawn_egg'
           },
           {
              'id': 383,
              'datavalue': 103,
              'name': 'Spawn Llama',
              'type': 'spawn_egg'
           },
           {
              'id': 383,
              'datavalue': 105,
              'name': 'Spawn Parrot',
              'type': 'spawn_egg'
           },
           {
              'id': 383,
              'datavalue': 120,
              'name': 'Spawn Villager',
              'type': 'spawn_egg'
           },
           {
              'id': 384,
              'datavalue': 0,
              'name': 'Bottle o' Enchanting',
              'type': 'experience_bottle'
           },
           {
              'id': 385,
              'datavalue': 0,
              'name': 'Fire Charge',
              'type': 'fire_charge'
           },
           {
              'id': 386,
              'datavalue': 0,
              'name': 'Book and Quill',
              'type': 'writable_book'
           },
           {
              'id': 387,
              'datavalue': 0,
              'name': 'Written Book',
              'type': 'written_book'
           },
           {
              'id': 388,
              'datavalue': 0,
              'name': 'Emerald',
              'type': 'emerald'
           },
           {
              'id': 389,
              'datavalue': 0,
              'name': 'Item Frame',
              'type': 'item_frame'
           },
           {
              'id': 390,
              'datavalue': 0,
              'name': 'Flower Pot',
              'type': 'flower_pot'
           },
           {
              'id': 391,
              'datavalue': 0,
              'name': 'Carrot',
              'type': 'carrot'
           },
           {
              'id': 392,
              'datavalue': 0,
              'name': 'Potato',
              'type': 'potato'
           },
           {
              'id': 393,
              'datavalue': 0,
              'name': 'Baked Potato',
              'type': 'baked_potato'
           },
           {
              'id': 394,
              'datavalue': 0,
              'name': 'Poisonous Potato',
              'type': 'poisonous_potato'
           },
           {
              'id': 395,
              'datavalue': 0,
              'name': 'Empty Map',
              'type': 'map'
           },
           {
              'id': 396,
              'datavalue': 0,
              'name': 'Golden Carrot',
              'type': 'golden_carrot'
           },
           {
              'id': 397,
              'datavalue': 0,
              'name': 'Mob Head (Skeleton)',
              'type': 'skull'
           },
           {
              'id': 397,
              'datavalue': 1,
              'name': 'Mob Head (Wither Skeleton)',
              'type': 'skull'
           },
           {
              'id': 397,
              'datavalue': 2,
              'name': 'Mob Head (Zombie)',
              'type': 'skull'
           },
           {
              'id': 397,
              'datavalue': 3,
              'name': 'Mob Head (Human)',
              'type': 'skull'
           },
           {
              'id': 397,
              'datavalue': 4,
              'name': 'Mob Head (Creeper)',
              'type': 'skull'
           },
           {
              'id': 397,
              'datavalue': 5,
              'name': 'Mob Head (Dragon)',
              'type': 'skull'
           },
           {
              'id': 398,
              'datavalue': 0,
              'name': 'Carrot on a Stick',
              'type': 'carrot_on_a_stick'
           },
           {
              'id': 399,
              'datavalue': 0,
              'name': 'Nether Star',
              'type': 'nether_star'
           },
           {
              'id': 400,
              'datavalue': 0,
              'name': 'Pumpkin Pie',
              'type': 'pumpkin_pie'
           },
           {
              'id': 401,
              'datavalue': 0,
              'name': 'Firework Rocket',
              'type': 'fireworks'
           },
           {
              'id': 402,
              'datavalue': 0,
              'name': 'Firework Star',
              'type': 'firework_charge'
           },
           {
              'id': 403,
              'datavalue': 0,
              'name': 'Enchanted Book',
              'type': 'enchanted_book'
           },
           {
              'id': 404,
              'datavalue': 0,
              'name': 'Redstone Comparator',
              'type': 'comparator'
           },
           {
              'id': 405,
              'datavalue': 0,
              'name': 'Nether Brick',
              'type': 'netherbrick'
           },
           {
              'id': 406,
              'datavalue': 0,
              'name': 'Nether Quartz',
              'type': 'quartz'
           },
           {
              'id': 407,
              'datavalue': 0,
              'name': 'Minecart with TNT',
              'type': 'tnt_minecart'
           },
           {
              'id': 408,
              'datavalue': 0,
              'name': 'Minecart with Hopper',
              'type': 'hopper_minecart'
           },
           {
              'id': 409,
              'datavalue': 0,
              'name': 'Prismarine Shard',
              'type': 'prismarine_shard'
           },
           {
              'id': 410,
              'datavalue': 0,
              'name': 'Prismarine Crystals',
              'type': 'prismarine_crystals'
           },
           {
              'id': 411,
              'datavalue': 0,
              'name': 'Raw Rabbit',
              'type': 'rabbit'
           },
           {
              'id': 412,
              'datavalue': 0,
              'name': 'Cooked Rabbit',
              'type': 'cooked_rabbit'
           },
           {
              'id': 413,
              'datavalue': 0,
              'name': 'Rabbit Stew',
              'type': 'rabbit_stew'
           },
           {
              'id': 414,
              'datavalue': 0,
              'name': 'Rabbit's Foot',
              'type': 'rabbit_foot'
           },
           {
              'id': 415,
              'datavalue': 0,
              'name': 'Rabbit Hide',
              'type': 'rabbit_hide'
           },
           {
              'id': 416,
              'datavalue': 0,
              'name': 'Armor Stand',
              'type': 'armor_stand'
           },
           {
              'id': 417,
              'datavalue': 0,
              'name': 'Iron Horse Armor',
              'type': 'iron_horse_armor'
           },
           {
              'id': 418,
              'datavalue': 0,
              'name': 'Golden Horse Armor',
              'type': 'golden_horse_armor'
           },
           {
              'id': 419,
              'datavalue': 0,
              'name': 'Diamond Horse Armor',
              'type': 'diamond_horse_armor'
           },
           {
              'id': 420,
              'datavalue': 0,
              'name': 'Lead',
              'type': 'lead'
           },
           {
              'id': 421,
              'datavalue': 0,
              'name': 'Name Tag',
              'type': 'name_tag'
           },
           {
              'id': 422,
              'datavalue': 0,
              'name': 'Minecart with Command Block',
              'type': 'command_block_minecart'
           },
           {
              'id': 423,
              'datavalue': 0,
              'name': 'Raw Mutton',
              'type': 'mutton'
           },
           {
              'id': 424,
              'datavalue': 0,
              'name': 'Cooked Mutton',
              'type': 'cooked_mutton'
           },
           {
              'id': 425,
              'datavalue': 0,
              'name': 'Banner',
              'type': 'banner'
           },
           {
              'id': 426,
              'datavalue': 0,
              'name': 'End Crystal',
              'type': 'end_crystal'
           },
           {
              'id': 427,
              'datavalue': 0,
              'name': 'Spruce Door',
              'type': 'spruce_door'
           },
           {
              'id': 428,
              'datavalue': 0,
              'name': 'Birch Door',
              'type': 'birch_door'
           },
           {
              'id': 429,
              'datavalue': 0,
              'name': 'Jungle Door',
              'type': 'jungle_door'
           },
           {
              'id': 430,
              'datavalue': 0,
              'name': 'Acacia Door',
              'type': 'acacia_door'
           },
           {
              'id': 431,
              'datavalue': 0,
              'name': 'Dark Oak Door',
              'type': 'dark_oak_door'
           },
           {
              'id': 432,
              'datavalue': 0,
              'name': 'Chorus Fruit',
              'type': 'chorus_fruit'
           },
           {
              'id': 433,
              'datavalue': 0,
              'name': 'Popped Chorus Fruit',
              'type': 'popped_chorus_fruit'
           },
           {
              'id': 434,
              'datavalue': 0,
              'name': 'Beetroot',
              'type': 'beetroot'
           },
           {
              'id': 435,
              'datavalue': 0,
              'name': 'Beetroot Seeds',
              'type': 'beetroot_seeds'
           },
           {
              'id': 436,
              'datavalue': 0,
              'name': 'Beetroot Soup',
              'type': 'beetroot_soup'
           },
           {
              'id': 437,
              'datavalue': 0,
              'name': 'Dragon's Breath',
              'type': 'dragon_breath'
           },
           {
              'id': 438,
              'datavalue': 0,
              'name': 'Splash Potion',
              'type': 'splash_potion'
           },
           {
              'id': 439,
              'datavalue': 0,
              'name': 'Spectral Arrow',
              'type': 'spectral_arrow'
           },
           {
              'id': 440,
              'datavalue': 0,
              'name': 'Tipped Arrow',
              'type': 'tipped_arrow'
           },
           {
              'id': 441,
              'datavalue': 0,
              'name': 'Lingering Potion',
              'type': 'lingering_potion'
           },
           {
              'id': 442,
              'datavalue': 0,
              'name': 'Shield',
              'type': 'shield'
           },
           {
              'id': 443,
              'datavalue': 0,
              'name': 'Elytra',
              'type': 'elytra'
           },
           {
              'id': 444,
              'datavalue': 0,
              'name': 'Spruce Boat',
              'type': 'spruce_boat'
           },
           {
              'id': 445,
              'datavalue': 0,
              'name': 'Birch Boat',
              'type': 'birch_boat'
           },
           {
              'id': 446,
              'datavalue': 0,
              'name': 'Jungle Boat',
              'type': 'jungle_boat'
           },
           {
              'id': 447,
              'datavalue': 0,
              'name': 'Acacia Boat',
              'type': 'acacia_boat'
           },
           {
              'id': 448,
              'datavalue': 0,
              'name': 'Dark Oak Boat',
              'type': 'dark_oak_boat'
           },
           {
              'id': 449,
              'datavalue': 0,
              'name': 'Totem of Undying',
              'type': 'totem_of_undying'
           },
           {
              'id': 450,
              'datavalue': 0,
              'name': 'Shulker Shell',
              'type': 'shulker_shell'
           },
           {
              'id': 452,
              'datavalue': 0,
              'name': 'Iron Nugget',
              'type': 'iron_nugget'
           },
           {
              'id': 453,
              'datavalue': 0,
              'name': 'Knowledge Book',
              'type': 'knowledge_book'
           },
           {
              'id': 2256,
              'datavalue': 0,
              'name': '13 Disc',
              'type': 'record_13'
           },
           {
              'id': 2257,
              'datavalue': 0,
              'name': 'Cat Disc',
              'type': 'record_cat'
           },
           {
              'id': 2258,
              'datavalue': 0,
              'name': 'Blocks Disc',
              'type': 'record_blocks'
           },
           {
              'id': 2259,
              'datavalue': 0,
              'name': 'Chirp Disc',
              'type': 'record_chirp'
           },
           {
              'id': 2260,
              'datavalue': 0,
              'name': 'Far Disc',
              'type': 'record_far'
           },
           {
              'id': 2261,
              'datavalue': 0,
              'name': 'Mall Disc',
              'type': 'record_mall'
           },
           {
              'id': 2262,
              'datavalue': 0,
              'name': 'Mellohi Disc',
              'type': 'record_mellohi'
           },
           {
              'id': 2263,
              'datavalue': 0,
              'name': 'Stal Disc',
              'type': 'record_stal'
           },
           {
              'id': 2264,
              'datavalue': 0,
              'name': 'Strad Disc',
              'type': 'record_strad'
           },
           {
              'id': 2265,
              'datavalue': 0,
              'name': 'Ward Disc',
              'type': 'record_ward'
           },
           {
              'id': 2266,
              'datavalue': 0,
              'name': '11 Disc',
              'type': 'record_11'
           },
           {
              'id': 2267,
              'datavalue': 0,
              'name': 'Wait Disc',
              'type': 'record_wait'
           }
        ]";
            
    

    }
}
