using Zx;
using static Zx.Env;

await "plantuml -o ../img -tsvg diagrams";
await "pandoc --defaults doc/defaults.yaml";