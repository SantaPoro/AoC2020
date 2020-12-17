import Control.Monad
import System.IO

main = do
  contents <- readFile "Day01/Haskell/input.txt"
  print . solution $ map readInt . lines $ contents

readInt :: String -> Int
readInt = read

solution :: [Int] -> Int
solution xs = foldl (*) 1 $ head $ filter (\x -> foldl (+) 0 x == 2020) [[x, y, z] | x <- xs, y <- xs, z <- xs]
