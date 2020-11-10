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
using DMDVision.Contracts.RandomHbbft.ContractDefinition;

namespace DMDVision.Contracts.RandomHbbft
{
    public partial class RandomHbbftService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, RandomHbbftDeployment randomHbbftDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<RandomHbbftDeployment>().SendRequestAndWaitForReceiptAsync(randomHbbftDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, RandomHbbftDeployment randomHbbftDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<RandomHbbftDeployment>().SendRequestAsync(randomHbbftDeployment);
        }

        public static async Task<RandomHbbftService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, RandomHbbftDeployment randomHbbftDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, randomHbbftDeployment, cancellationTokenSource);
            return new RandomHbbftService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public RandomHbbftService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<BigInteger> CurrentSeedQueryAsync(CurrentSeedFunction currentSeedFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<CurrentSeedFunction, BigInteger>(currentSeedFunction, blockParameter);
        }

        
        public Task<BigInteger> CurrentSeedQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<CurrentSeedFunction, BigInteger>(null, blockParameter);
        }

        public Task<string> SetCurrentSeedRequestAsync(SetCurrentSeedFunction setCurrentSeedFunction)
        {
             return ContractHandler.SendRequestAsync(setCurrentSeedFunction);
        }

        public Task<TransactionReceipt> SetCurrentSeedRequestAndWaitForReceiptAsync(SetCurrentSeedFunction setCurrentSeedFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setCurrentSeedFunction, cancellationToken);
        }

        public Task<string> SetCurrentSeedRequestAsync(BigInteger currentSeed)
        {
            var setCurrentSeedFunction = new SetCurrentSeedFunction();
                setCurrentSeedFunction.CurrentSeed = currentSeed;
            
             return ContractHandler.SendRequestAsync(setCurrentSeedFunction);
        }

        public Task<TransactionReceipt> SetCurrentSeedRequestAndWaitForReceiptAsync(BigInteger currentSeed, CancellationTokenSource cancellationToken = null)
        {
            var setCurrentSeedFunction = new SetCurrentSeedFunction();
                setCurrentSeedFunction.CurrentSeed = currentSeed;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setCurrentSeedFunction, cancellationToken);
        }
    }
}
