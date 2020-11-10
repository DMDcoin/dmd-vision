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
using DMDVision.Contracts.Registry.ContractDefinition;

namespace DMDVision.Contracts.Registry
{
    public partial class RegistryService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, RegistryDeployment registryDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<RegistryDeployment>().SendRequestAndWaitForReceiptAsync(registryDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, RegistryDeployment registryDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<RegistryDeployment>().SendRequestAsync(registryDeployment);
        }

        public static async Task<RegistryService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, RegistryDeployment registryDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, registryDeployment, cancellationTokenSource);
            return new RegistryService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public RegistryService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<BigInteger> FeeQueryAsync(FeeFunction feeFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<FeeFunction, BigInteger>(feeFunction, blockParameter);
        }

        
        public Task<BigInteger> FeeQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<FeeFunction, BigInteger>(null, blockParameter);
        }

        public Task<string> OwnerQueryAsync(OwnerFunction ownerFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OwnerFunction, string>(ownerFunction, blockParameter);
        }

        
        public Task<string> OwnerQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OwnerFunction, string>(null, blockParameter);
        }

        public Task<string> SetOwnerRequestAsync(SetOwnerFunction setOwnerFunction)
        {
             return ContractHandler.SendRequestAsync(setOwnerFunction);
        }

        public Task<TransactionReceipt> SetOwnerRequestAndWaitForReceiptAsync(SetOwnerFunction setOwnerFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setOwnerFunction, cancellationToken);
        }

        public Task<string> SetOwnerRequestAsync(string new_)
        {
            var setOwnerFunction = new SetOwnerFunction();
                setOwnerFunction.New = new_;
            
             return ContractHandler.SendRequestAsync(setOwnerFunction);
        }

        public Task<TransactionReceipt> SetOwnerRequestAndWaitForReceiptAsync(string new_, CancellationTokenSource cancellationToken = null)
        {
            var setOwnerFunction = new SetOwnerFunction();
                setOwnerFunction.New = new_;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setOwnerFunction, cancellationToken);
        }

        public Task<string> ReserveRequestAsync(ReserveFunction reserveFunction)
        {
             return ContractHandler.SendRequestAsync(reserveFunction);
        }

        public Task<TransactionReceipt> ReserveRequestAndWaitForReceiptAsync(ReserveFunction reserveFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(reserveFunction, cancellationToken);
        }

        public Task<string> ReserveRequestAsync(byte[] name)
        {
            var reserveFunction = new ReserveFunction();
                reserveFunction.Name = name;
            
             return ContractHandler.SendRequestAsync(reserveFunction);
        }

        public Task<TransactionReceipt> ReserveRequestAndWaitForReceiptAsync(byte[] name, CancellationTokenSource cancellationToken = null)
        {
            var reserveFunction = new ReserveFunction();
                reserveFunction.Name = name;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(reserveFunction, cancellationToken);
        }

        public Task<string> TransferRequestAsync(TransferFunction transferFunction)
        {
             return ContractHandler.SendRequestAsync(transferFunction);
        }

        public Task<TransactionReceipt> TransferRequestAndWaitForReceiptAsync(TransferFunction transferFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(transferFunction, cancellationToken);
        }

        public Task<string> TransferRequestAsync(byte[] name, string to)
        {
            var transferFunction = new TransferFunction();
                transferFunction.Name = name;
                transferFunction.To = to;
            
             return ContractHandler.SendRequestAsync(transferFunction);
        }

        public Task<TransactionReceipt> TransferRequestAndWaitForReceiptAsync(byte[] name, string to, CancellationTokenSource cancellationToken = null)
        {
            var transferFunction = new TransferFunction();
                transferFunction.Name = name;
                transferFunction.To = to;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(transferFunction, cancellationToken);
        }

        public Task<string> DropRequestAsync(DropFunction dropFunction)
        {
             return ContractHandler.SendRequestAsync(dropFunction);
        }

        public Task<TransactionReceipt> DropRequestAndWaitForReceiptAsync(DropFunction dropFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(dropFunction, cancellationToken);
        }

        public Task<string> DropRequestAsync(byte[] name)
        {
            var dropFunction = new DropFunction();
                dropFunction.Name = name;
            
             return ContractHandler.SendRequestAsync(dropFunction);
        }

        public Task<TransactionReceipt> DropRequestAndWaitForReceiptAsync(byte[] name, CancellationTokenSource cancellationToken = null)
        {
            var dropFunction = new DropFunction();
                dropFunction.Name = name;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(dropFunction, cancellationToken);
        }

        public Task<string> SetDataRequestAsync(SetDataFunction setDataFunction)
        {
             return ContractHandler.SendRequestAsync(setDataFunction);
        }

        public Task<TransactionReceipt> SetDataRequestAndWaitForReceiptAsync(SetDataFunction setDataFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setDataFunction, cancellationToken);
        }

        public Task<string> SetDataRequestAsync(byte[] name, string key, byte[] value)
        {
            var setDataFunction = new SetDataFunction();
                setDataFunction.Name = name;
                setDataFunction.Key = key;
                setDataFunction.Value = value;
            
             return ContractHandler.SendRequestAsync(setDataFunction);
        }

        public Task<TransactionReceipt> SetDataRequestAndWaitForReceiptAsync(byte[] name, string key, byte[] value, CancellationTokenSource cancellationToken = null)
        {
            var setDataFunction = new SetDataFunction();
                setDataFunction.Name = name;
                setDataFunction.Key = key;
                setDataFunction.Value = value;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setDataFunction, cancellationToken);
        }

        public Task<string> SetAddressRequestAsync(SetAddressFunction setAddressFunction)
        {
             return ContractHandler.SendRequestAsync(setAddressFunction);
        }

        public Task<TransactionReceipt> SetAddressRequestAndWaitForReceiptAsync(SetAddressFunction setAddressFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setAddressFunction, cancellationToken);
        }

        public Task<string> SetAddressRequestAsync(byte[] name, string key, string value)
        {
            var setAddressFunction = new SetAddressFunction();
                setAddressFunction.Name = name;
                setAddressFunction.Key = key;
                setAddressFunction.Value = value;
            
             return ContractHandler.SendRequestAsync(setAddressFunction);
        }

        public Task<TransactionReceipt> SetAddressRequestAndWaitForReceiptAsync(byte[] name, string key, string value, CancellationTokenSource cancellationToken = null)
        {
            var setAddressFunction = new SetAddressFunction();
                setAddressFunction.Name = name;
                setAddressFunction.Key = key;
                setAddressFunction.Value = value;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setAddressFunction, cancellationToken);
        }

        public Task<string> SetUintRequestAsync(SetUintFunction setUintFunction)
        {
             return ContractHandler.SendRequestAsync(setUintFunction);
        }

        public Task<TransactionReceipt> SetUintRequestAndWaitForReceiptAsync(SetUintFunction setUintFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setUintFunction, cancellationToken);
        }

        public Task<string> SetUintRequestAsync(byte[] name, string key, BigInteger value)
        {
            var setUintFunction = new SetUintFunction();
                setUintFunction.Name = name;
                setUintFunction.Key = key;
                setUintFunction.Value = value;
            
             return ContractHandler.SendRequestAsync(setUintFunction);
        }

        public Task<TransactionReceipt> SetUintRequestAndWaitForReceiptAsync(byte[] name, string key, BigInteger value, CancellationTokenSource cancellationToken = null)
        {
            var setUintFunction = new SetUintFunction();
                setUintFunction.Name = name;
                setUintFunction.Key = key;
                setUintFunction.Value = value;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setUintFunction, cancellationToken);
        }

        public Task<string> ProposeReverseRequestAsync(ProposeReverseFunction proposeReverseFunction)
        {
             return ContractHandler.SendRequestAsync(proposeReverseFunction);
        }

        public Task<TransactionReceipt> ProposeReverseRequestAndWaitForReceiptAsync(ProposeReverseFunction proposeReverseFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(proposeReverseFunction, cancellationToken);
        }

        public Task<string> ProposeReverseRequestAsync(string name, string who)
        {
            var proposeReverseFunction = new ProposeReverseFunction();
                proposeReverseFunction.Name = name;
                proposeReverseFunction.Who = who;
            
             return ContractHandler.SendRequestAsync(proposeReverseFunction);
        }

        public Task<TransactionReceipt> ProposeReverseRequestAndWaitForReceiptAsync(string name, string who, CancellationTokenSource cancellationToken = null)
        {
            var proposeReverseFunction = new ProposeReverseFunction();
                proposeReverseFunction.Name = name;
                proposeReverseFunction.Who = who;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(proposeReverseFunction, cancellationToken);
        }

        public Task<string> ConfirmReverseRequestAsync(ConfirmReverseFunction confirmReverseFunction)
        {
             return ContractHandler.SendRequestAsync(confirmReverseFunction);
        }

        public Task<TransactionReceipt> ConfirmReverseRequestAndWaitForReceiptAsync(ConfirmReverseFunction confirmReverseFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(confirmReverseFunction, cancellationToken);
        }

        public Task<string> ConfirmReverseRequestAsync(string name)
        {
            var confirmReverseFunction = new ConfirmReverseFunction();
                confirmReverseFunction.Name = name;
            
             return ContractHandler.SendRequestAsync(confirmReverseFunction);
        }

        public Task<TransactionReceipt> ConfirmReverseRequestAndWaitForReceiptAsync(string name, CancellationTokenSource cancellationToken = null)
        {
            var confirmReverseFunction = new ConfirmReverseFunction();
                confirmReverseFunction.Name = name;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(confirmReverseFunction, cancellationToken);
        }

        public Task<string> ConfirmReverseAsRequestAsync(ConfirmReverseAsFunction confirmReverseAsFunction)
        {
             return ContractHandler.SendRequestAsync(confirmReverseAsFunction);
        }

        public Task<TransactionReceipt> ConfirmReverseAsRequestAndWaitForReceiptAsync(ConfirmReverseAsFunction confirmReverseAsFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(confirmReverseAsFunction, cancellationToken);
        }

        public Task<string> ConfirmReverseAsRequestAsync(string name, string who)
        {
            var confirmReverseAsFunction = new ConfirmReverseAsFunction();
                confirmReverseAsFunction.Name = name;
                confirmReverseAsFunction.Who = who;
            
             return ContractHandler.SendRequestAsync(confirmReverseAsFunction);
        }

        public Task<TransactionReceipt> ConfirmReverseAsRequestAndWaitForReceiptAsync(string name, string who, CancellationTokenSource cancellationToken = null)
        {
            var confirmReverseAsFunction = new ConfirmReverseAsFunction();
                confirmReverseAsFunction.Name = name;
                confirmReverseAsFunction.Who = who;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(confirmReverseAsFunction, cancellationToken);
        }

        public Task<string> RemoveReverseRequestAsync(RemoveReverseFunction removeReverseFunction)
        {
             return ContractHandler.SendRequestAsync(removeReverseFunction);
        }

        public Task<string> RemoveReverseRequestAsync()
        {
             return ContractHandler.SendRequestAsync<RemoveReverseFunction>();
        }

        public Task<TransactionReceipt> RemoveReverseRequestAndWaitForReceiptAsync(RemoveReverseFunction removeReverseFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(removeReverseFunction, cancellationToken);
        }

        public Task<TransactionReceipt> RemoveReverseRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<RemoveReverseFunction>(null, cancellationToken);
        }

        public Task<string> SetFeeRequestAsync(SetFeeFunction setFeeFunction)
        {
             return ContractHandler.SendRequestAsync(setFeeFunction);
        }

        public Task<TransactionReceipt> SetFeeRequestAndWaitForReceiptAsync(SetFeeFunction setFeeFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setFeeFunction, cancellationToken);
        }

        public Task<string> SetFeeRequestAsync(BigInteger amount)
        {
            var setFeeFunction = new SetFeeFunction();
                setFeeFunction.Amount = amount;
            
             return ContractHandler.SendRequestAsync(setFeeFunction);
        }

        public Task<TransactionReceipt> SetFeeRequestAndWaitForReceiptAsync(BigInteger amount, CancellationTokenSource cancellationToken = null)
        {
            var setFeeFunction = new SetFeeFunction();
                setFeeFunction.Amount = amount;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setFeeFunction, cancellationToken);
        }

        public Task<string> DrainRequestAsync(DrainFunction drainFunction)
        {
             return ContractHandler.SendRequestAsync(drainFunction);
        }

        public Task<string> DrainRequestAsync()
        {
             return ContractHandler.SendRequestAsync<DrainFunction>();
        }

        public Task<TransactionReceipt> DrainRequestAndWaitForReceiptAsync(DrainFunction drainFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(drainFunction, cancellationToken);
        }

        public Task<TransactionReceipt> DrainRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<DrainFunction>(null, cancellationToken);
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

        public Task<string> GetOwnerQueryAsync(GetOwnerFunction getOwnerFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetOwnerFunction, string>(getOwnerFunction, blockParameter);
        }

        
        public Task<string> GetOwnerQueryAsync(byte[] name, BlockParameter blockParameter = null)
        {
            var getOwnerFunction = new GetOwnerFunction();
                getOwnerFunction.Name = name;
            
            return ContractHandler.QueryAsync<GetOwnerFunction, string>(getOwnerFunction, blockParameter);
        }

        public Task<bool> HasReverseQueryAsync(HasReverseFunction hasReverseFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<HasReverseFunction, bool>(hasReverseFunction, blockParameter);
        }

        
        public Task<bool> HasReverseQueryAsync(byte[] name, BlockParameter blockParameter = null)
        {
            var hasReverseFunction = new HasReverseFunction();
                hasReverseFunction.Name = name;
            
            return ContractHandler.QueryAsync<HasReverseFunction, bool>(hasReverseFunction, blockParameter);
        }

        public Task<string> GetReverseQueryAsync(GetReverseFunction getReverseFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetReverseFunction, string>(getReverseFunction, blockParameter);
        }

        
        public Task<string> GetReverseQueryAsync(byte[] name, BlockParameter blockParameter = null)
        {
            var getReverseFunction = new GetReverseFunction();
                getReverseFunction.Name = name;
            
            return ContractHandler.QueryAsync<GetReverseFunction, string>(getReverseFunction, blockParameter);
        }

        public Task<bool> CanReverseQueryAsync(CanReverseFunction canReverseFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<CanReverseFunction, bool>(canReverseFunction, blockParameter);
        }

        
        public Task<bool> CanReverseQueryAsync(string data, BlockParameter blockParameter = null)
        {
            var canReverseFunction = new CanReverseFunction();
                canReverseFunction.Data = data;
            
            return ContractHandler.QueryAsync<CanReverseFunction, bool>(canReverseFunction, blockParameter);
        }

        public Task<string> ReverseQueryAsync(ReverseFunction reverseFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ReverseFunction, string>(reverseFunction, blockParameter);
        }

        
        public Task<string> ReverseQueryAsync(string data, BlockParameter blockParameter = null)
        {
            var reverseFunction = new ReverseFunction();
                reverseFunction.Data = data;
            
            return ContractHandler.QueryAsync<ReverseFunction, string>(reverseFunction, blockParameter);
        }

        public Task<bool> ReservedQueryAsync(ReservedFunction reservedFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ReservedFunction, bool>(reservedFunction, blockParameter);
        }

        
        public Task<bool> ReservedQueryAsync(byte[] name, BlockParameter blockParameter = null)
        {
            var reservedFunction = new ReservedFunction();
                reservedFunction.Name = name;
            
            return ContractHandler.QueryAsync<ReservedFunction, bool>(reservedFunction, blockParameter);
        }
    }
}
