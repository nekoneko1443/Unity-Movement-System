# Unity Creative Movement

UnityでMinecraftのクリエイティブモードのような
自由な3D移動を実装するためのライブラリです。

## Features

- WASDによる水平移動
- Spaceによる上昇
- Shiftによる下降
- マウスによる視点操作
- カメラ方向に応じた移動
- XYZ方向への自由な3D移動

## Requirements

- Unity 6
- Input System

## Controls

| Input | Action |
|---|---|
| W | 前進 |
| A | 左移動 |
| S | 後退 |
| D | 右移動 |
| Space | 上昇 |
| Shift | 下降 |
| Mouse | 視点操作 |

## Usage

1. `CreativePlayer.prefab` をSceneに配置します。
2. 必要に応じてInspectorから移動速度を変更します。
3. Playすると自由に3D移動できます。

## Project Structure

```text
Assets/
├── CreativeMovement/
│   ├── Runtime/
│   ├── Input/
│   └── Prefabs/
│
└── Samples/
    └── Basic/
        └── SampleScene.unity
