using Zx;
using static Zx.Env;

// [prerequisite] setting.txt ファイルの1行目にPlantUML jarファイルのパスを書いておくこと
var PlantUmlJarPath = await "type setting.txt";

await $"java -jar {PlantUmlJarPath} -o ../img -tsvg diagrams";
await "pandoc --defaults doc/defaults.yaml -o out/out.html";
