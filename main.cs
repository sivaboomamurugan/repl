using System;

class Program {
  public static void Main (string[] args) {
    var tierBatchSize = 30;
    var messageCountToRead = 34;
                var iterations = tierBatchSize > 0 ? (int)Math.Ceiling(messageCountToRead / (tierBatchSize * 1.0d)) : tierBatchSize;

    Console.WriteLine (iterations);
  }
}