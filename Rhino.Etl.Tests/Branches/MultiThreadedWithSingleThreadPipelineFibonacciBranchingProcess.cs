﻿using Rhino.Etl.Core;
using Rhino.Etl.Core.Operations;
using Rhino.Etl.Core.Pipelines;

namespace Rhino.Etl.Tests.Branches
{
	public class MultiThreadedWithSingleThreadPipelineFibonacciBranchingProcess : AbstractFibonacciBranchingProcess
	{
		public MultiThreadedWithSingleThreadPipelineFibonacciBranchingProcess(int numberOfFibonacciIterations, int numberOfChildOperations)
			: base(numberOfFibonacciIterations, numberOfChildOperations)
		{
		}

		protected override AbstractBranchingOperation CreateBranchingOperation()
		{
			return new MultiThreadedBranchingOperation();
		}

		protected override IPipelineExecuter CreatePipelineExecuter()
		{
			return new SingleThreadedNonCachedPipelineExecuter();
		}
	}
}