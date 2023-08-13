module FAQBotCC.LuaNames

open System.Collections.Generic

let private lua51 = "https://www.lua.org/manual/5.1/manual.html#"
let private lua52 = "https://www.lua.org/manual/5.2/manual.html#"
let private lua53 = "https://www.lua.org/manual/5.3/manual.html#"

let private modules =
  [| "coroutine", lua51 + "5.2"
     "debug", lua51 + "5.9"
     "math", lua51 + "5.6"
     "package", lua51 + "5.3"
     "string", lua51 + "5.4"
     "table", lua51 + "5.5"
     "bit32", lua52 + "6.7"
     "utf8", lua53 + "6.5" |]
  |> Map.ofArray

let private lua51Vars =
  [| "_G"
     "_VERSION"
     "assert"
     "collectgarbage"
     "coroutine.create"
     "coroutine.resume"
     "coroutine.running"
     "coroutine.status"
     "coroutine.wrap"
     "coroutine.yield"
     "debug.debug"
     "debug.getfenv"
     "debug.gethook"
     "debug.getinfo"
     "debug.getlocal"
     "debug.getmetatable"
     "debug.getregistry"
     "debug.getupvalue"
     "debug.setfenv"
     "debug.sethook"
     "debug.setlocal"
     "debug.setmetatable"
     "debug.setupvalue"
     "debug.traceback"
     "dofile"
     "error"
     "getfenv"
     "getmetatable"
     "ipairs"
     "load"
     "loadfile"
     "loadstring"
     "math.abs"
     "math.acos"
     "math.asin"
     "math.atan"
     "math.atan2"
     "math.ceil"
     "math.cos"
     "math.cosh"
     "math.deg"
     "math.exp"
     "math.floor"
     "math.fmod"
     "math.frexp"
     "math.huge"
     "math.ldexp"
     "math.log"
     "math.log10"
     "math.max"
     "math.min"
     "math.modf"
     "math.pi"
     "math.pow"
     "math.rad"
     "math.random"
     "math.randomseed"
     "math.sin"
     "math.sinh"
     "math.sqrt"
     "math.tan"
     "math.tanh"
     "next"
     "package.cpath"
     "package.loaded"
     "package.loaders"
     "package.loadlib"
     "package.path"
     "package.preload"
     "package.seeall"
     "pairs"
     "pcall"
     "print"
     "rawequal"
     "rawget"
     "rawset"
     "require"
     "select"
     "setfenv"
     "setmetatable"
     "string.byte"
     "string.char"
     "string.dump"
     "string.find"
     "string.format"
     "string.gmatch"
     "string.gsub"
     "string.len"
     "string.lower"
     "string.match"
     "string.rep"
     "string.reverse"
     "string.sub"
     "string.upper"
     "table.concat"
     "table.insert"
     "table.maxn"
     "table.remove"
     "table.sort"
     "tonumber"
     "tostring"
     "type"
     "unpack"
     "xpcall" |]

let private lua52Vars =
  [| "bit32.arshift"
     "bit32.band"
     "bit32.bnot"
     "bit32.bor"
     "bit32.btest"
     "bit32.bxor"
     "bit32.extract"
     "bit32.lrotate"
     "bit32.lshift"
     "bit32.replace"
     "bit32.rrotate"
     "bit32.rshift"
     "debug.join"
     "debug.upvalueid"
     "package.searchpath"
     "rawlen"
     "table.pack"
     "table.unpack" |]

let private lua53Vars =
  [| "coroutine.isyieldable"
     "string.pack"
     "string.unpack"
     "table.move"
     "utf8.char"
     "utf8.charpattern"
     "utf8.codepoint"
     "utf8.codes"
     "utf8.len"
     "utf8.offset" |]

let vars : IReadOnlyDictionary<string, string> =
  let out = Dictionary<string, string>(modules)
  Array.iter (fun k -> out[k] <- $"{lua51}pdf-{k}") lua51Vars
  Array.iter (fun k -> out[k] <- $"{lua52}pdf-{k}") lua52Vars
  Array.iter (fun k -> out[k] <- $"{lua53}pdf-{k}") lua53Vars
  out
