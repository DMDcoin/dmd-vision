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
using DMDVision.Contracts.IMetadataRegistry.ContractDefinition;

namespace DMDVision.Contracts.IMetadataRegistry
{
    public partial class IMetadataRegistryService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, IMetadataRegistryDeployment iMetadataRegistryDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<IMetadataRegistryDeployment>().SendRequestAndWaitForReceiptAsync(iMetadataRegistryDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, IMetadataRegistryDeployment iMetadataRegistryDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<IMetadataRegistryDeployment>().SendRequestAsync(iMetadataRegistryDeployment);
        }

        public static async Task<IMetadataRegistryService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, IMetadataRegistryDeployment iMetadataRegistryDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, iMetadataRegistryDeployment, cancellationTokenSource);
            return new IMetadataRegistryService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public IMetadataRegistryService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<byte[]> GetDataQueryAsync(GetDataFunction getDataFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetDataFunction, byte[]>(getDataFunction, blockParameter);
        }

        
        public Task<byte[]> GetDataQueryAsync(byte[] name, string key, BlockParameter blockParameter = null)
        {
            var getDataFunction = new GetDataFunction();
                getDataFunction.Name = name;
                getDataFunction.Key = key;
            
            return ContractHandler.QueryAsync<GetDataFunction, byte[]>(getDataFunction, blockParameter);
        }

        public Task<string> GetAddressQueryAsync(GetAddressFunction getAddressFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetAddressFunction, string>(getAddressFunction, blockParameter);
        }

        
        public Task<string> GetAddressQueryAsync(byte[] name, string key, BlockParameter blockParameter = null)
        {
            var getAddressFunction = new GetAddressFunction();
                getAddressFunction.Name = name;
                getAddressFunction.Key = key;
            
            return ContractHandler.QueryAsync<GetAddressFunction, string>(getAddressFunction, blockParameter);
        }

        public Task<BigInteger> GetUintQueryAsync(GetUintFunction getUintFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetUintFunction, BigInteger>(getUintFunction, blockParameter);
        }

        
        public Task<BigInteger> GetUintQueryAsync(byte[] name, string key, BlockParameter blockParameter = null)
        {
            var getUintFunction = new GetUintFunction();
                getUintFunction.Name = name;
                getUintFunction.Key = key;
            
            return ContractHandler.QueryAsync<GetUintFunction, BigInteger>(getUintFunction, blockParameter);
        }
    }
}
