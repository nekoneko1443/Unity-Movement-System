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


## インストール方法
1. Window→Package Management→Package Managerを開く。
2. 左上の「＋」から、「Install Package from git URL...」をクリックする。
3. `https://github.com/nekoneko1443/Unity-Movement-System.git?path=/CreativeMovement`を入力してインストールする。
4. Package Managerの「Creative Movement」（このパッケージ）のSampleタブをクリックする。
<img width="1454" height="629" alt="Package Manager image" src="https://github.com/user-attachments/assets/a66f1217-4463-4403-a823-e50d7b12d0fa" />
5. Reimportの場合、すでに「Assets/Samples/...」にサンプルがインストールされているため、動作確認が可能です。「Assets/Samples/CreativeMovement/1.0.0/Basic/SampleScene」を開き、Playすると動作確認できます。（importの場合はそこをクリックし、同様の操作を行なってください。）<br>
<img width="483" height="516" alt="Unity Project image" src="https://github.com/user-attachments/assets/25a3504d-deb7-4b98-a77b-a0a4f7c7d0d2" />

## Usage
1. `CreativePlayer.prefab`をSceneに配置する。
2. 必要に応じてInspectorから移動速度を変更する。
3. Playすると自由に3D移動できます。
4. Character Mover(Script)のMoveSpeedから移動速度を変更することも可能です。<br>
<img width="403" height="498" alt="Character Mover image" src="https://github.com/user-attachments/assets/9a2b1cee-a255-450e-921f-e27d9f36bb16" />


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
