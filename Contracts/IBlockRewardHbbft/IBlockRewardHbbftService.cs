using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.Contracts;
using System.Threading;
using DMDVision.Contracts.IBlockRewardHbbft.ContractDefinition;

namespace DMDVision.Contracts.IBlockRewardHbbft
{
    public partial class IBlockRewardHbbftService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, IBlockRewardHbbftDeployment iBlockRewardHbbftDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<IBlockRewardHbbftDeployment>().SendRequestAndWaitForReceiptAsync(iBlockRewardHbbftDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, IBlockRewardHbbftDeployment iBlockRewardHbbftDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<IBlockRewardHbbftDeployment>().SendRequestAsync(iBlockRewardHbbftDeployment);
        }

        public static async Task<IBlockRewardHbbftService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, IBlockRewardHbbftDeployment iBlockRewardHbbftDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, iBlockRewardHbbftDeployment, cancellationTokenSource);
            return new IBlockRewardHbbftService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public IBlockRewardHbbftService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<string> InitializeRequestAsync(InitializeFunction initializeFunction)
        {
             return ContractHandler.SendRequestAsync(initializeFunction);
        }

        public Task<TransactionReceipt> InitializeRequestAndWaitForReceiptAsync(InitializeFunction initializeFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(initializeFunction, cancellationToken);
        }

        public Task<string> InitializeRequestAsync(string returnValue1)
        {
            var initializeFunction = new InitializeFunction();
                initializeFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAsync(initializeFunction);
        }

        public Task<TransactionReceipt> InitializeRequestAndWaitForReceiptAsync(string returnValue1, CancellationTokenSource cancellationToken = null)
        {
            var initializeFunction = new InitializeFunction();
                initializeFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(initializeFunction, cancellationToken);
        }

        public Task<List<BigInteger>> EpochsPoolGotRewardForQueryAsync(EpochsPoolGotRewardForFunction epochsPoolGotRewardForFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<EpochsPoolGotRewardForFunction, List<BigInteger>>(epochsPoolGotRewardForFunction, blockParameter);
        }

        
        public Task<List<BigInteger>> EpochsPoolGotRewardForQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var epochsPoolGotRewardForFunction = new EpochsPoolGotRewardForFunction();
                epochsPoolGotRewardForFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<EpochsPoolGotRewardForFunction, List<BigInteger>>(epochsPoolGotRewardForFunction, blockParameter);
        }
    }
}
