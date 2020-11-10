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
using DMDVision.Contracts.IBlockRewardHbbftCoins.ContractDefinition;

namespace DMDVision.Contracts.IBlockRewardHbbftCoins
{
    public partial class IBlockRewardHbbftCoinsService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, IBlockRewardHbbftCoinsDeployment iBlockRewardHbbftCoinsDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<IBlockRewardHbbftCoinsDeployment>().SendRequestAndWaitForReceiptAsync(iBlockRewardHbbftCoinsDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, IBlockRewardHbbftCoinsDeployment iBlockRewardHbbftCoinsDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<IBlockRewardHbbftCoinsDeployment>().SendRequestAsync(iBlockRewardHbbftCoinsDeployment);
        }

        public static async Task<IBlockRewardHbbftCoinsService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, IBlockRewardHbbftCoinsDeployment iBlockRewardHbbftCoinsDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, iBlockRewardHbbftCoinsDeployment, cancellationTokenSource);
            return new IBlockRewardHbbftCoinsService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public IBlockRewardHbbftCoinsService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<string> TransferRewardRequestAsync(TransferRewardFunction transferRewardFunction)
        {
             return ContractHandler.SendRequestAsync(transferRewardFunction);
        }

        public Task<TransactionReceipt> TransferRewardRequestAndWaitForReceiptAsync(TransferRewardFunction transferRewardFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(transferRewardFunction, cancellationToken);
        }

        public Task<string> TransferRewardRequestAsync(BigInteger returnValue1, string returnValue2)
        {
            var transferRewardFunction = new TransferRewardFunction();
                transferRewardFunction.ReturnValue1 = returnValue1;
                transferRewardFunction.ReturnValue2 = returnValue2;
            
             return ContractHandler.SendRequestAsync(transferRewardFunction);
        }

        public Task<TransactionReceipt> TransferRewardRequestAndWaitForReceiptAsync(BigInteger returnValue1, string returnValue2, CancellationTokenSource cancellationToken = null)
        {
            var transferRewardFunction = new TransferRewardFunction();
                transferRewardFunction.ReturnValue1 = returnValue1;
                transferRewardFunction.ReturnValue2 = returnValue2;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(transferRewardFunction, cancellationToken);
        }

        public Task<BigInteger> GetDelegatorRewardQueryAsync(GetDelegatorRewardFunction getDelegatorRewardFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetDelegatorRewardFunction, BigInteger>(getDelegatorRewardFunction, blockParameter);
        }

        
        public Task<BigInteger> GetDelegatorRewardQueryAsync(BigInteger returnValue1, BigInteger returnValue2, string returnValue3, BlockParameter blockParameter = null)
        {
            var getDelegatorRewardFunction = new GetDelegatorRewardFunction();
                getDelegatorRewardFunction.ReturnValue1 = returnValue1;
                getDelegatorRewardFunction.ReturnValue2 = returnValue2;
                getDelegatorRewardFunction.ReturnValue3 = returnValue3;
            
            return ContractHandler.QueryAsync<GetDelegatorRewardFunction, BigInteger>(getDelegatorRewardFunction, blockParameter);
        }

        public Task<BigInteger> GetValidatorRewardQueryAsync(GetValidatorRewardFunction getValidatorRewardFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetValidatorRewardFunction, BigInteger>(getValidatorRewardFunction, blockParameter);
        }

        
        public Task<BigInteger> GetValidatorRewardQueryAsync(BigInteger returnValue1, string returnValue2, BlockParameter blockParameter = null)
        {
            var getValidatorRewardFunction = new GetValidatorRewardFunction();
                getValidatorRewardFunction.ReturnValue1 = returnValue1;
                getValidatorRewardFunction.ReturnValue2 = returnValue2;
            
            return ContractHandler.QueryAsync<GetValidatorRewardFunction, BigInteger>(getValidatorRewardFunction, blockParameter);
        }
    }
}
