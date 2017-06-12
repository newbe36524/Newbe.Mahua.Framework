# Mahua打包设计

## 基本信息

信息    | 内容
----- | ----------------
文件扩展名 | .newbe.mpk.nupkg

## 基本思路

采用nuget包的信息将插件进行打包

## 包内基本结构

```yml
content
- Amanda.7z
  CQP.7z
  MPQ.7z
```

7z

```yml
lib
manifest.json
```
